using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public class Dashboard
    {
        public List<Account> Accounts { get; set; }
        public List<Expense> Expenses { get; set; }
        public List<Income> Incomes { get; set; }
        public List<Goal> Goals { get; set; }
        public List<CategoryTotalTransactions> CategoryTotalTransactions { get; set; }
    }
}
