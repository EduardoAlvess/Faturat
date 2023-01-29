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

        [HttpGet]
        public ActionResult Add()
        {
            var account = new Account();

            return PartialView("_AddAccountModal", account);
        }

        [HttpPost]
        public IActionResult Create(string name, double balance)
        {
            Account account = new Account()
            {
                Name = name,
                Balance = balance,
                isDeleted = false,
                CreationDate = DateTime.Now,
                UserId = _userProvider.GetUserId()
            };

            _databaseContext.Accounts.Add(account);
            _databaseContext.SaveChanges(account, "Added");

            return Redirect("/Accounts");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var account = _databaseContext.Accounts.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            return PartialView("_EditAccountModal", account);
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, double balance)
        {
            var accountToEdit = _databaseContext.Accounts.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            accountToEdit.Name = name;
            accountToEdit.Balance = balance;

            _databaseContext.SaveChanges(accountToEdit, "Modified");

            return Redirect("/Accounts");
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var account = _databaseContext.Accounts.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            account.isDeleted = true;
            _databaseContext.SaveChanges(account, "Modified");
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

        public Account GetById(int id)
        {
            return _databaseContext.Accounts.First(x => x.Id == id && x.isDeleted == false && x.UserId == _userProvider.GetUserId());
        }

        public ActionResult<List<Account>> GetAccounts()
        {
            var accounts = _databaseContext.Accounts.Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false).ToList();

            return Ok(accounts);
        }
    }
}
