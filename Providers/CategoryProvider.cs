using TCC.Models;
using TCC.Db;

namespace TCC.Providers
{
    public interface ICategoryProvider
    {
        List<Category> GetExpenseCategories();
        List<Category> GetIncomeCategories();
    }

    public class CategoryProvider : ICategoryProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDatabaseContext _databaseContext;

        public CategoryProvider(IHttpContextAccessor httpContextAccessor, IDatabaseContext databaseContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _databaseContext = databaseContext;
        }

        public List<Category> GetExpenseCategories()
        {
            return _databaseContext.Categories.Where(x => x.Type == CategoryType.Expense).ToList();
        }

        public List<Category> GetIncomeCategories()
        {
            return _databaseContext.Categories.Where(x => x.Type == CategoryType.Income).ToList();
        }
    }
}
