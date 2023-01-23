using TCC.Db;

namespace TCC.Providers
{
    public interface IUserProvider
    {
        int GetUserId();
    }

    public class UserProvider : IUserProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDatabaseContext _databaseContext;

        public UserProvider(IDatabaseContext databaseContext, IHttpContextAccessor httpContextAccessor)
        {
            _databaseContext = databaseContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public int GetUserId()
        {
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var id = _databaseContext.Users.First(x => x.UserName == userName).Id;
            return id;
        }
    }
}
