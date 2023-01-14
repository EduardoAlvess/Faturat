namespace TCC.Models
{
    public class EditIncome : Income
    {
        public List<Category> Categories { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
