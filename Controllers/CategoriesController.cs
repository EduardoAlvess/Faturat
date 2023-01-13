using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using TCC.Db;
using TCC.Models;

namespace TCC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IDatabaseContext _databaseContext;
        private readonly IMemoryCache _cache;

        public CategoriesController(IDatabaseContext databaseContext, IMemoryCache memoryCache)
        {
            _databaseContext = databaseContext;
            _cache = memoryCache;
        }

        [HttpGet]
        public ActionResult<List<Category>> GetExpenseCategories()
        {
            var categories = _cache.GetOrCreate("ExpenseCategories", item =>
            {
                item.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(86400);
                return _databaseContext.Categories.Where(x => x.Type == CategoryType.Expense).ToList();
            });

            return Ok(categories);
        }

        [HttpGet]
        public ActionResult<List<Category>> GetIncomeCategories()
        {
            var categories = _databaseContext.Categories.Where(x => x.Type == CategoryType.Income).ToList();

            return Ok(categories);
        }
    }
}
