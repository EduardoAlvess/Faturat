namespace TCC.Models
{
    public class AddExpense : Expense
    {
        public List<Category> Categories { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
