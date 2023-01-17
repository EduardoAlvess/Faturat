using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public class FilterTransactions
    {
        public List<Category> Categories { get; set; }
        public List<Account> Accounts { get; set; }
        public List<CategoryId> CategoriesIds { get; set; }
        public List<int> AccountsIds { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime InitialDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FinalDate { get; set; }

    }
}
