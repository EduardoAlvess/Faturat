using TCC.Models;
using TCC.Db;

namespace TCC.Providers
{
    public interface IAccountProvider
    {
        string GetAccountName(int id);
        List<Account> GetAccountsByUserId(int id);
        List<Account> GetAllAccounts();
    }

    public class AccountProvider : IAccountProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;

        public AccountProvider(IHttpContextAccessor httpContextAccessor, IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _httpContextAccessor = httpContextAccessor;
            _databaseContext = databaseContext;
            _userProvider = userProvider;
        }

        public string GetAccountName(int id)
        {
            return _databaseContext.Accounts.Where(x => x.Id == id && x.isDeleted == false && x.UserId == _userProvider.GetUserId())
                                                   .Select(a => a.Name)
                                                   .FirstOrDefault();
        }

        public List<Account> GetAccountsByUserId(int id)
        {
            return _databaseContext.Accounts.Where(x => x.UserId == id && x.isDeleted == false).ToList();
        }

        public List<Account> GetAllAccounts()
        {
            return _databaseContext.Accounts.Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false).ToList();
        }
    }
}
