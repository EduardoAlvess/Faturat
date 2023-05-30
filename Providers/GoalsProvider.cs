using TCC.Models;
using TCC.Db;

namespace TCC.Providers
{
    public interface IGoalsProvider
    {
        List<Goal> GetAllGoals();
    }

    public class GoalsProvider : IGoalsProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;

        public GoalsProvider(IHttpContextAccessor httpContextAccessor, IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _httpContextAccessor = httpContextAccessor;
            _databaseContext = databaseContext;
            _userProvider = userProvider;
        }

        public List<Goal> GetAllGoals()
        {
            return _databaseContext.Goals
                                   .Where(x => x.UserId == _userProvider.GetUserId() && x.IsDeleted == false)
                                   .ToList();
        }
    }
}
