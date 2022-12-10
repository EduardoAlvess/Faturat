using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Providers;
using TCC.Models;
using TCC.Db;

namespace TCC.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;

        public AccountsController(IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _databaseContext = databaseContext;
            _userProvider = userProvider;
        }

        public ActionResult Index()
        {
            var list = _databaseContext.Accounts.Where(x => x.isDeleted != true && x.UserId == _userProvider.GetUserId()).ToList();
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
            var accountToEdit = _databaseContext.Accounts.FirstOrDefault(x => x.Id == account.Id && x.UserId == _userProvider.GetUserId());

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
            var account = _databaseContext.Accounts.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            account.isDeleted = true;
            _databaseContext.SaveChanges(account, "Modified");
            return Json("Teste");
        }

        [HttpPost]
        public ActionResult AddBalance(int id, [FromBody] double value)
        {
            var account = _databaseContext.Accounts.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            account.Balance += value;
            _databaseContext.SaveChanges(account, "Modified");

            return Json("Teste");
        }

        [HttpPost]
        public ActionResult RemoveBalance(int id, [FromBody] double value)
        {
            var account = _databaseContext.Accounts.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            account.Balance -= value;
            _databaseContext.SaveChanges(account, "Modified");

            return Json("Teste");
        }
    }
}
