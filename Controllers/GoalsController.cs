using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Providers;
using TCC.Models;
using TCC.Db;

namespace TCC.Controllers
{
    [Authorize]
    public class GoalsController : Controller
    {
        private readonly IDatabaseContext _databaseContext;
        private readonly IUserProvider _userProvider;

        public GoalsController(IDatabaseContext databaseContext, IUserProvider userProvider)
        {
            _databaseContext = databaseContext;
            _userProvider = userProvider;
        }

        public IActionResult Index()
        {
            var list = _databaseContext.Goals.Where(x => x.IsDeleted != true && x.UserId == _userProvider.GetUserId()).ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var goal = new Goal()
            {
                FinalDate = DateTime.Now
            };

            return PartialView("_AddGoalModal", goal);
        }

        [HttpPost]
        public IActionResult Create(string name, double currentBalance, double finalBalance, DateTime finalDate)
        {
            Goal goal = new Goal()
            {
                UserId = _userProvider.GetUserId(),
                CurrentBalance = currentBalance,
                FinalBalance = finalBalance,
                CreationDate = DateTime.Now,
                FinalDate = finalDate,
                IsCompleted = false,
                IsDeleted = false,
                Name = name
            };

            _databaseContext.Goals.Add(goal);
            _databaseContext.SaveChanges(goal, "Added");

            return Redirect("/Goals");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var goal = _databaseContext.Goals.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            return PartialView("_EditGoalModal", goal);
        }

        [HttpPost]
        public IActionResult Edit(int id, string name, double currentBalance, double finalBalance, DateTime finalDate)
        {
            var goalToEdit = _databaseContext.Goals.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            goalToEdit.CurrentBalance = currentBalance;
            goalToEdit.FinalBalance = finalBalance;
            goalToEdit.FinalDate = finalDate;
            goalToEdit.Name = name;

            _databaseContext.SaveChanges(goalToEdit, "Modified");

            return Redirect("/Goals");
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var goal = _databaseContext.Goals.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            goal.IsDeleted = true;
            _databaseContext.SaveChanges(goal, "Modified");
        }

        [HttpPost]
        public void Complete(int id)
        {
            var goal = _databaseContext.Goals.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            goal.IsCompleted = true;
            goal.CurrentBalance = goal.FinalBalance;
            _databaseContext.SaveChanges(goal, "Modified");
        }
    }
}
