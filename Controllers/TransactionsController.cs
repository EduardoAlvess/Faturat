using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Providers;
using TCC.Db;

namespace TCC.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;

        public TransactionsController(IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _databaseContext = databaseContext;
            _userProvider = userProvider;
        }

        public IActionResult Index()
        {
            var list = _databaseContext.Transactions.Where(x => x.isDeleted != true && x.UserId == _userProvider.GetUserId()).ToList();
            return View("Index", list);
        }
    }
}
