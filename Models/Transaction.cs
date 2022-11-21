using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public abstract class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int AccountId { get; set; }
        public double Value { get; set; }
        public string Description { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
