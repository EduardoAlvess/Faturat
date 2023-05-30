using Microsoft.AspNetCore.Mvc.Rendering;

namespace TCC.Models
{
    public class EditExpense : Expense
    {
        public List<Category> Categories { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
