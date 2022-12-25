using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TCC.Db;
using TCC.Models;

namespace TCC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IDatabaseContext _databaseContext;

        public CategoriesController(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public ActionResult<List<ExpenseCategory>> GetExpenseCategories()
        {
            var categories = _databaseContext.Categories.OfType<ExpenseCategory>();

            return Ok(categories);
        }
    }
}
