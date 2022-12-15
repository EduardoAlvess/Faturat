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

        [HttpPost]
        public IActionResult Create([FromBody] Goal goal)
        {
            _databaseContext.Goals.Add(goal);
            _databaseContext.SaveChanges(goal, "Added");
            return Json("Teste");
        }

        [HttpPost]
        public ActionResult Edit([FromBody] Goal goal)
        {
            var goalToEdit = _databaseContext.Goals.FirstOrDefault(x => x.Id == goal.Id && x.UserId == _userProvider.GetUserId());

            if (goal != null)
            {
                goalToEdit.Name = goal.Name;
                goalToEdit.CurrentBalance = goal.CurrentBalance;
                goalToEdit.FinalBalance = goal.FinalBalance;
                goalToEdit.FinalDate = goal.FinalDate;
                goalToEdit.IsCompleted = goal.IsCompleted;
                _databaseContext.SaveChanges(goalToEdit, "Modified");
                return Json("Atualizado");
            }
            return Json("Erro");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var goal = _databaseContext.Goals.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());
            goal.IsDeleted = true;
            _databaseContext.SaveChanges(goal, "Modified");
            return Json("Teste");
        }

        [HttpPost]
        public ActionResult AddBalance(int id, [FromBody] double value)
        {
            var goal = _databaseContext.Goals.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            goal.CurrentBalance += value;

            CheckBalance(goal);

            _databaseContext.SaveChanges(goal, "Modified");

            return Json("Teste");
        }

        [HttpPost]
        public ActionResult RemoveBalance(int id, [FromBody] double value)
        {
            var goal = _databaseContext.Goals.FirstOrDefault(x => x.Id == id && x.UserId == _userProvider.GetUserId());

            goal.CurrentBalance -= value;

            CheckBalance(goal);

            _databaseContext.SaveChanges(goal, "Modified");

            return Json("Teste");
        }

        private void CheckBalance(Goal goal)
        {
            if(goal.CurrentBalance >= goal.FinalBalance)
                goal.IsCompleted = true;
            else
                goal.IsCompleted = false;
        }
    }
}
