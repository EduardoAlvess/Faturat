using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public enum CategoryId
    {
        Gym = 1,
        Clothing = 2,
        Education = 3,
        Pet = 4,
        Electronics = 5,
        Health = 6,
        Home = 7,
        Taxes = 8,
        Leisure = 9,
        Others = 10,
        Restaurant = 11,
        Services = 12,
        Supermarket = 13,
        Transportation = 14,
        Travel  = 15,
        Alimentation = 16,
        Bills = 17,
        Awards = 18,
        Gift = 19,
        Investments = 20,
        Salary  = 21
    }

    public enum CategoryType
    {
        Income = 0,
        Expense = 1
    }
    public class Category
    {
        [Key]
        public CategoryId Id { get; set; }
        public string Name { get; set; }
        [Required]
        public CategoryType Type { get; set; }
    }
}
