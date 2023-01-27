using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Providers;
using TCC.Models;
using TCC.Db;

namespace TCC.Controllers
{
    //[Authorize]
    public class IncomesController : Controller
    {
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;
        private readonly IAccountProvider _accountProvider;
        private readonly ICategoryProvider _categoriesProvider;

        public IncomesController(IDatabaseContext databaseContext, IUserProvider userProvider, IAccountProvider accountProvider, ICategoryProvider categoryProvider)
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

            var transactions = _databaseContext.Transactions.OfType<Income>()
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
            var incomeInfos = new AddIncome()
            {
                TransactionDate = DateTime.Now,
                Categories = _categoriesProvider.GetIncomeCategories(),
                Accounts = _accountProvider.GetAccountsByUserId(_userProvider.GetUserId())
            };

            return PartialView("_AddIncomeModal", incomeInfos);
        }

        [HttpPost]
        public IActionResult Create(double value, string description, CategoryId categoryId, int accountId, DateTime transactionDate)
        {
            Income income = new Income()
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

            _databaseContext.Transactions.Add(income);
            _databaseContext.SaveChanges(income, "Added");

            return Redirect("/Incomes");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var income = GetById(id);

            var editIncome = new EditIncome()
            {
                Id = income.Id,
                Value = income.Value,
                UserId = income.UserId,
                AccountId = income.AccountId,
                isDeleted = income.isDeleted,
                CategoryId = income.CategoryId,
                Description = income.Description,
                CreationDate = income.CreationDate,
                TransactionDate = income.TransactionDate,
                Categories = _categoriesProvider.GetIncomeCategories(),
                Accounts = _accountProvider.GetAccountsByUserId(income.UserId)
            };

            return PartialView("_EditIncomeModal", editIncome);
        }

        [HttpPost]
        public void Edit(int id, double value, string description, CategoryId categoryId, int accountId, DateTime transactionDate)
        {
            var incomeToEdit = _databaseContext.Transactions.OfType<Income>().FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            incomeToEdit.TransactionDate = transactionDate;
            incomeToEdit.Description = description;
            incomeToEdit.CategoryId = categoryId;
            incomeToEdit.AccountId = accountId;
            incomeToEdit.Value = value;
            _databaseContext.SaveChanges(incomeToEdit, "Modified");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var income = _databaseContext.Transactions.OfType<Income>().FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            income.isDeleted = true;
            _databaseContext.SaveChanges(income, "Modified");
            return Json("Teste");
        }

        [HttpGet]
        public Income GetById(int id)
        {
            return _databaseContext.Transactions.OfType<Income>().First(x => x.Id == id);
        }

        [HttpGet]
        public double SumIncomes()
        {
            var incomes = _databaseContext.Transactions
                                          .OfType<Income>()
                                          .Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false)
                                          .ToList();

            double totalIncomes = 0;
            incomes.ForEach(x => totalIncomes += x.Value);

            return totalIncomes;
        }
    }
}
