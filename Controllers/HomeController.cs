using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Models;
using TCC.Providers;

[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IAccountProvider _accountProvider;
    private readonly ITransactionsProvider _transactionsProvider;
    private readonly IGoalsProvider _goalsProvider;
    private readonly ICategoryProvider _categoryProvider;

    public HomeController(ILogger<HomeController> logger, IAccountProvider accountProvider, ITransactionsProvider transactionsProvider, 
                          IGoalsProvider goalsProvider, ICategoryProvider categoryProvider)
    {
        _logger = logger;
        _goalsProvider = goalsProvider;
        _accountProvider = accountProvider;
        _categoryProvider = categoryProvider;
        _transactionsProvider = transactionsProvider;
    }

    public IActionResult Index()
    {
        var model = new Dashboard
        {
            CategoryTotalTransactions = _categoryProvider.GetCategoryTotalTransactions(),
            Expenses = _transactionsProvider.GetAllExpenses(),
            Incomes = _transactionsProvider.GetAllIncomes(),
            Accounts = _accountProvider.GetAllAccounts(),
            Goals = _goalsProvider.GetAllGoals()
        };

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    //[HttpGet]
    //public string DateTimeNow()
    //{
    //    return DateTime.Now.ToString("MM/dd/yyyy");
    //}
}
