using Microsoft.AspNetCore.Mvc;
using TCC.Db;

namespace TCC.Providers
{
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
            return _databaseContext.Accounts.Where(x => x.Id == id && x.UserId == _userProvider.GetUserId())
                                                   .Select(a => a.Name)
                                                   .FirstOrDefault();
        }
    }
}
