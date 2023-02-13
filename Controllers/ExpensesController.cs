using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Providers;
using TCC.Models;
using TCC.Db;

namespace TCC.Controllers
{
    [Authorize]
    public class ExpensesController : Controller
    {
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;
        private readonly IAccountProvider _accountProvider;
        private readonly ICategoryProvider _categoriesProvider;

        public ExpensesController(IDatabaseContext databaseContext, IUserProvider userProvider, IAccountProvider accountProvider, ICategoryProvider categoryProvider)
        {
            _databaseContext = databaseContext;
            _userProvider = userProvider;
            _accountProvider = accountProvider;
            _categoriesProvider = categoryProvider;

        }

        [HttpGet]
        public IActionResult Index()
        {
            var userId = _userProvider.GetUserId();

            var accounts = _databaseContext.Accounts.Where(x => x.isDeleted == false && x.UserId == userId).ToList();

            var transactions = _databaseContext.Transactions.OfType<Expense>()
                                                            .Where(x => x.isDeleted != true && accounts.Select(y => y.Id).Contains(x.AccountId))
                                                            .OrderByDescending(x => x.TransactionDate)
                                                            .ToList()
                                                            .OfType<Transaction>()
                                                            .ToList();

            return View("_Grid", transactions);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var expenseInfos = new AddExpense()
            {
                TransactionDate = DateTime.Now,
                Categories = _categoriesProvider.GetExpenseCategories(),
                Accounts = _accountProvider.GetAccountsByUserId(_userProvider.GetUserId())
            };

            return PartialView("_AddExpenseModal", expenseInfos);
        }

        [HttpPost]
        public IActionResult Create(double value, string description, CategoryId categoryId, int accountId, DateTime transactionDate)
        {
            Expense expense = new Expense()
            {
                UserId = _userProvider.GetUserId(),
                TransactionDate = transactionDate,
                CreationDate = DateTime.Now,
                Description = description,
                CategoryId = categoryId,
                AccountId = accountId,
                isDeleted = false,
                Value = value,
            };

            _databaseContext.Transactions.Add(expense);

            RemoveFromAccount(expense.AccountId, expense.Value);

            _databaseContext.SaveChanges(expense, "Added");

            return Redirect("/Expenses");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var expense = GetById(id);

            var editExpense = new EditExpense()
            {
                Id = expense.Id,
                Value = expense.Value,
                UserId = expense.UserId,
                AccountId = expense.AccountId,
                isDeleted = expense.isDeleted,
                CategoryId = expense.CategoryId,
                Description = expense.Description,
                CreationDate = expense.CreationDate,
                TransactionDate = expense.TransactionDate,
                Categories = _categoriesProvider.GetExpenseCategories(),
                Accounts = _accountProvider.GetAccountsByUserId(expense.UserId)
            };

            return PartialView("_EditExpenseModal", editExpense);
        }

        [HttpPost]
        public void Edit(int id, double value, string description, CategoryId categoryId, int accountId, DateTime transactionDate)
        {
            var expenseToEdit = _databaseContext.Transactions.OfType<Expense>().FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            expenseToEdit.TransactionDate = transactionDate;
            expenseToEdit.Description = description;
            expenseToEdit.CategoryId = categoryId;
            expenseToEdit.AccountId = accountId;
            expenseToEdit.Value = value;
            _databaseContext.SaveChanges(expenseToEdit, "Modified");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var expense = _databaseContext.Transactions.OfType<Expense>().FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            expense.isDeleted = true;
            _databaseContext.SaveChanges(expense, "Modified");
            return Json("Teste");
        }

        [HttpGet]
        public Expense GetById(int id)
        {
            return _databaseContext.Transactions.OfType<Expense>().First(x => x.Id == id);
        }

        [HttpGet]
        public double SumExpenses()
        {
            var userId = _userProvider.GetUserId();

            var accounts = _databaseContext.Accounts.Where(x => x.UserId == userId && x.isDeleted == false).Select(x => x.Id).ToList();

            var expenses = _databaseContext.Transactions
                                           .OfType<Expense>()
                                           .Where(x => x.UserId == userId && x.isDeleted == false 
                                                                          && accounts.Contains(x.AccountId))
                                           .ToList();

            double totalExpenses = 0;
            expenses.ForEach(x => totalExpenses += x.Value);

            return totalExpenses;
        }

        private void RemoveFromAccount(int accountId, double value)
        {
            var account = _databaseContext.Accounts.Where(x => x.Id == accountId && x.UserId == _userProvider.GetUserId() && x.isDeleted == false).First();

            account.Balance -= value;
        }
    }
}
