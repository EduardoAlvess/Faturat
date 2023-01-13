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

        public ExpensesController(IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _databaseContext = databaseContext;
            _userProvider = userProvider;
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

        [HttpPost]
        public ActionResult Edit([FromBody] Expense expense)
        {
            var expenseToEdit = _databaseContext.Transactions.OfType<Expense>().FirstOrDefault(x => x.Id == expense.Id && x.UserId == _userProvider.GetUserId());

            if (expense != null)
            {
                expenseToEdit.TransactionDate = expense.TransactionDate;
                expenseToEdit.Description = expense.Description;
                expenseToEdit.CategoryId = expense.CategoryId;
                expenseToEdit.AccountId = expense.AccountId;
                expenseToEdit.Value = expense.Value;
                _databaseContext.SaveChanges(expenseToEdit, "Modified");
                return Json("Atualizado");
            }
            return Json("Erro");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var expense = _databaseContext.Transactions.OfType<Expense>().FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            expense.isDeleted = true;
            _databaseContext.SaveChanges(expense, "Modified");
            return Json("Teste");
        }
    }
}
