using Microsoft.AspNetCore.Mvc;
using TCC.Models;
using TCC.Db;
using Microsoft.AspNetCore.Authorization;

namespace TCC.Controllers
{
    [Authorize]
    public class IncomesController : Controller
    {
        private readonly IDatabaseContext _databaseContext;

        public IncomesController(IDatabaseContext databaseContext) => _databaseContext = databaseContext;

        [HttpGet]
        public IActionResult Index()
        {
            var list = _databaseContext.Transactions.OfType<Income>().Where(x => x.isDeleted != true && x.UserId == GetUserId()).ToList();
            return View("Index", list);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Income income)
        {
            _databaseContext.Transactions.Add(income);
            _databaseContext.SaveChanges(income, "Added");
            return Json("Teste");
        }

        [HttpPost]
        public ActionResult Edit([FromBody] Income income)
        {
            var incomeToEdit = _databaseContext.Transactions.OfType<Income>().FirstOrDefault(x => x.Id == income.Id && x.UserId == GetUserId());

            if (income != null)
            {
                incomeToEdit.TransactionDate = income.TransactionDate;
                incomeToEdit.Description = income.Description;
                incomeToEdit.CategoryId = income.CategoryId;
                incomeToEdit.isReceived = income.isReceived;
                incomeToEdit.AccountId = income.AccountId;
                incomeToEdit.Category = income.Category;
                incomeToEdit.Value = income.Value;
                _databaseContext.SaveChanges(incomeToEdit, "Modified");
                return Json("Atualizado");
            }
            return Json("Erro");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var income = _databaseContext.Transactions.OfType<Income>().FirstOrDefault(x => x.Id == id && x.UserId == GetUserId());
            income.isDeleted = true;
            _databaseContext.SaveChanges(income, "Modified");
            return Json("Teste");
        }

        public int GetUserId() => _databaseContext.Users.First(x => x.UserName == User.Identity.Name).Id;
    }
}
