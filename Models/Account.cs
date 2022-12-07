using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IconId { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public bool isDeleted { get; set; }
    }
}
