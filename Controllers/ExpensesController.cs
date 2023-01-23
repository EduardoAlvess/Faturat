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
            var list = _databaseContext.Transactions.OfType<Expense>().Where(x => x.isDeleted != true && x.UserId == _userProvider.GetUserId()).ToList();
            return View("Index", list);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Expense expense)
        {
            _databaseContext.Transactions.Add(expense);
            _databaseContext.SaveChanges(expense, "Added");
            return Json("Teste");
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
    }
}
