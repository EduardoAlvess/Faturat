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
            var userId = _userProvider.GetUserId();

            var accounts = _databaseContext.Accounts.Where(x => x.isDeleted == false && x.UserId == userId ).ToList();

            var transactions = _databaseContext.Transactions.Where(x => x.isDeleted != true && accounts.Select(y => y.Id).Contains(x.AccountId)).ToList();

            return View("Index", transactions);
        }
    }
}
