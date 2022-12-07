using Microsoft.AspNetCore.Mvc;
using TCC.Models;
using TCC.Db;

namespace TCC.Controllers
{
    public class IncomesController : Controller
    {
        private readonly IDatabaseContext _databaseContext;

        public IncomesController(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = _databaseContext.Transactions.OfType<Income>().Where(x => x.isDeleted != true).ToList();
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
            var incomeToEdit = _databaseContext.Transactions.OfType<Income>().FirstOrDefault(x => x.Id == income.Id);

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
            var income = _databaseContext.Transactions.OfType<Income>().FirstOrDefault(x => x.Id == id);
            income.isDeleted = true;
            _databaseContext.SaveChanges(income, "Modified");
            return Json("Teste");
        }

        // POST: TransactionsController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: TransactionsController/Edit/5

        // POST: TransactionsController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: TransactionsController/Delete/5

        // POST: TransactionsController/Delete/5
    }
}
