using TCC.Models;
using TCC.Db;

namespace TCC.Providers
{
    public interface ICategoryProvider
    {
        List<Category> GetExpenseCategories();
        List<Category> GetIncomeCategories();
        List<CategoryTotalTransactions> GetCategoryTotalTransactions();
    }

    public class CategoryProvider : ICategoryProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;

        public CategoryProvider(IHttpContextAccessor httpContextAccessor, IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _httpContextAccessor = httpContextAccessor;
            _databaseContext = databaseContext;
            _userProvider = userProvider;
        }

        public List<Category> GetExpenseCategories()
        {
            return _databaseContext.Categories.Where(x => x.Type == CategoryType.Expense).ToList();
        }

        public List<Category> GetIncomeCategories()
        {
            return _databaseContext.Categories.Where(x => x.Type == CategoryType.Income).ToList();
        }
        public List<Category> GetAllCategories()
        {
            return _databaseContext.Categories.ToList();
        }

        public List<CategoryTotalTransactions> GetCategoryTotalTransactions()
        {
            var model = new List<CategoryTotalTransactions>();

            foreach(Category category in GetAllCategories())
            {
                var values = _databaseContext.Transactions
                                        .Where(x => x.UserId == _userProvider.GetUserId() && x.isDeleted == false 
                                                                                          && x.CategoryId == category.Id)
                                        .Select(x => x.Value)
                                        .ToList();

                double total = 0;
                values.ForEach(x => total += (double)x);

                var categoryTotalTransactions = new CategoryTotalTransactions
                {
                    CategoryName = category.Name,
                    CategoryType = category.Type,
                    TotalAmount = total
                };

                model.Add(categoryTotalTransactions);
            }

            return model;
        }
    }
}
