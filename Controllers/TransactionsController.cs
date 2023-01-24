using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Providers;
using TCC.Db;
using TCC.Models;

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

            var transactions = _databaseContext.Transactions.Where(x => x.isDeleted != true && accounts.Select(y => y.Id).Contains(x.AccountId))
                                                            .OrderByDescending(x => x.TransactionDate)
                                                            .ToList();

            return View("_Grid", transactions);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var transaction = _databaseContext.Transactions.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            transaction.isDeleted = true;
            _databaseContext.SaveChanges(transaction, "Modified");
        }

        [HttpGet]
        public ActionResult Filter()
        {
            var filterTransactions = new FilterTransactions
            {
                Categories = _databaseContext.Categories.ToList(),
                Accounts = _databaseContext.Accounts.Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false).ToList(),
                InitialDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1),
                FinalDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).AddDays(-1)
            };

            return PartialView("_FilterTransactionsModal", filterTransactions);
        }

        [HttpPost]
        public IActionResult Filter(List<CategoryId> categoriesIds, List<int> accountsIds, DateTime initialDate, DateTime finalDate)
        {
            if(categoriesIds.Count() == 0)
                categoriesIds.AddRange(_databaseContext.Categories.Select(x => x.Id).ToList());

            if(accountsIds.Count() == 0)
                accountsIds.AddRange(_databaseContext.Accounts
                                                     .Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false)
                                                     .Select(x => x.Id)
                                                     .ToList());

            var transactions = _databaseContext.Transactions
                                               .Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false
                                                                                                 && categoriesIds.Contains(x.CategoryId) 
                                                                                                 && accountsIds.Contains(x.AccountId)
                                                                                                 && x.TransactionDate >= initialDate
                                                                                                 && x.TransactionDate <= finalDate)
                                               .OrderByDescending(x => x.TransactionDate)
                                               .ToList();

            ViewData["UseLayout"] = false;

            return PartialView("_Grid", transactions);
        }
    }
}
