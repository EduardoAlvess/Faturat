using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Db;

namespace TCC.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        private readonly IDatabaseContext _databaseContext;

        public TransactionsController(IDatabaseContext databaseContext) => _databaseContext = databaseContext;

        public IActionResult Index()
        {
            var list = _databaseContext.Transactions.Where(x => x.isDeleted != true && x.UserId == GetUserId()).ToList();
            return View("Index", list);
        }

        public int GetUserId() => _databaseContext.Users.First(x => x.UserName == User.Identity.Name).Id;

    }
}
