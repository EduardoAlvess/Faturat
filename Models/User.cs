using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
