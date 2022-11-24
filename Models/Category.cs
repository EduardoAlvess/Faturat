using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public enum CategoryType
    {
        Gym = 0,
        Clothing = 1,
        Education = 2,
        Pet = 3,
        Electronics = 4,
        Health = 5,
        Home = 6,
        Taxes = 7,
        Leisure = 8,
        Others = 9,
        Restaurant = 10,
        Services = 11,
        Supermarket = 12,
        Transportation = 13,
        Travel  = 14,
        Awards = 15,
        Gift = 16,
        Investments = 17,
        Salary  = 18
    }
    public abstract class Category
    {
        [Key]
        public int Id { get; set; }
        public int IconId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public CategoryType Type { get; set; }
    }
}
