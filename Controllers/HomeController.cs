using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TCC.Providers;
using TCC.Models;

[Authorize]
public class HomeController : Controller
{
    private readonly IAccountProvider _accountProvider;
    private readonly ITransactionsProvider _transactionsProvider;
    private readonly IGoalsProvider _goalsProvider;
    private readonly ICategoryProvider _categoryProvider;

    public HomeController(IAccountProvider accountProvider, ITransactionsProvider transactionsProvider, 
                          IGoalsProvider goalsProvider, ICategoryProvider categoryProvider)
    {
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
}
