using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCC.Db;
using TCC.Models;

namespace TCC.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IDatabaseContext _databaseContext;

        public AccountsController(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        
        public ActionResult Index()
        {
            var list = _databaseContext.Accounts.Where(x => x.isDeleted != true).ToList();
            return View(list);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Account account)
        {
            _databaseContext.Accounts.Add(account);
            _databaseContext.SaveChanges(account, "Added");
            return Json("Teste");
        }


        [HttpPost]
        public ActionResult Edit([FromBody] Account account)
        {
            var accountToEdit = _databaseContext.Accounts.FirstOrDefault(x => x.Id == account.Id);

            if(account != null)
            {
                accountToEdit.Balance = account.Balance;
                accountToEdit.Name = account.Name;
                accountToEdit.IconId = account.IconId;
                _databaseContext.SaveChanges(accountToEdit, "Modified");
                return Json("Atualizado");
            }
            return Json("Erro");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var account = _databaseContext.Accounts.FirstOrDefault(x => x.Id == id);
            account.isDeleted = true;
            _databaseContext.SaveChanges(account, "Modified");
            return Json("Teste");
        }
    }
}
