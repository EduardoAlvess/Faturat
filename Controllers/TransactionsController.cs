using Microsoft.AspNetCore.Mvc;
using TCC.Db;

namespace TCC.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly IDatabaseContext _databaseContext;

        public TransactionsController(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            var list = _databaseContext.Transactions.Where(x => x.isDeleted != true).ToList();
            return View("Index", list);
        }
    }
}
