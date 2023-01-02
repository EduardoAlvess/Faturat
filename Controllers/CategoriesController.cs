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

        [HttpGet]
        public ActionResult<List<ExpenseCategory>> GetExpenseCategories()
        {
            var categories = _databaseContext.Categories.OfType<ExpenseCategory>();

            return Ok(categories);
        }

        [HttpGet]
        public ActionResult<List<IncomeCategory>> GetIncomeCategories()
        {
            var categories = _databaseContext.Categories.OfType<IncomeCategory>();

            return Ok(categories);
        }
    }
}
