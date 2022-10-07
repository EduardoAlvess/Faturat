using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public abstract class Category
    {
        [Key]
        public int Id { get; set; }
        public int IconId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
