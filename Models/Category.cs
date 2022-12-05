using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public enum CategoryType
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
        Awards = 16,
        Gift = 17,
        Investments = 18,
        Salary  = 19
    }
    public abstract class Category
    {
        [Key]
        public int Id { get; set; }
        public int IconId { get; set; }
        public string Description { get; set; }
        //public CategoryType Type { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
