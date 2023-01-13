using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Providers;
using TCC.Models;
using TCC.Db;

namespace TCC.Controllers
{
    [Authorize]
    public class IncomesController : Controller
    {
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;

        public IncomesController(IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _databaseContext = databaseContext;
            _userProvider = userProvider;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = _databaseContext.Transactions.OfType<Income>().Where(x => x.isDeleted != true && x.UserId == _userProvider.GetUserId()).ToList();
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
            var incomeToEdit = _databaseContext.Transactions.OfType<Income>().FirstOrDefault(x => x.Id == income.Id && x.UserId == _userProvider.GetUserId());

            if (income != null)
            {
                incomeToEdit.TransactionDate = income.TransactionDate;
                incomeToEdit.Description = income.Description;
                incomeToEdit.CategoryId = income.CategoryId;
                incomeToEdit.AccountId = income.AccountId;
                incomeToEdit.Value = income.Value;
                _databaseContext.SaveChanges(incomeToEdit, "Modified");
                return Json("Atualizado");
            }
            return Json("Erro");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var income = _databaseContext.Transactions.OfType<Income>().FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            income.isDeleted = true;
            _databaseContext.SaveChanges(income, "Modified");
            return Json("Teste");
        }
    }
}
