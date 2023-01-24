using TCC.Models;
using TCC.Db;

namespace TCC.Providers
{
    public interface ITransactionsProvider
    {
        List<Expense> GetAllExpenses();
        List<Income> GetAllIncomes();
    }

    public class TransactionsProvider : ITransactionsProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;

        public TransactionsProvider(IHttpContextAccessor httpContextAccessor, IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _httpContextAccessor = httpContextAccessor;
            _databaseContext = databaseContext;
            _userProvider = userProvider;
        }

        public List<Expense> GetAllExpenses()
        {
            return _databaseContext.Transactions
                                   .OfType<Expense>()
                                   .Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false)
                                   .ToList();
        }

        public List<Income> GetAllIncomes()
        {
            return _databaseContext.Transactions
                                   .OfType<Income>()
                                   .Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false)
                                   .ToList();
        }
    }
}
