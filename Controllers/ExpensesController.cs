using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Db;
using TCC.Models;

namespace TCC.Controllers
{
    [Authorize]
    public class ExpensesController : Controller
    {
        private readonly IDatabaseContext _databaseContext;

        public ExpensesController(IDatabaseContext databaseContext) => _databaseContext = databaseContext;

        [HttpGet]
        public IActionResult Index()
        {
            var list = _databaseContext.Transactions.OfType<Expense>().Where(x => x.isDeleted != true && x.UserId == GetUserId()).ToList();
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
            var expenseToEdit = _databaseContext.Transactions.OfType<Expense>().FirstOrDefault(x => x.Id == expense.Id && x.UserId == GetUserId());

            if (expense != null)
            {
                expenseToEdit.TransactionDate = expense.TransactionDate;
                expenseToEdit.Description = expense.Description;
                expenseToEdit.CategoryId = expense.CategoryId;
                expenseToEdit.AccountId = expense.AccountId;
                expenseToEdit.Category = expense.Category;
                expenseToEdit.isPaid = expense.isPaid;
                expenseToEdit.Value = expense.Value;
                _databaseContext.SaveChanges(expenseToEdit, "Modified");
                return Json("Atualizado");
            }
            return Json("Erro");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var expense = _databaseContext.Transactions.OfType<Expense>().FirstOrDefault(x => x.Id == id && x.UserId == GetUserId());
            expense.isDeleted = true;
            _databaseContext.SaveChanges(expense, "Modified");
            return Json("Teste");
        }

        public int GetUserId() => _databaseContext.Users.First(x => x.UserName == User.Identity.Name).Id;
    }
}
