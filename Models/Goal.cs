using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public double CurrentBalance { get; set; }
        public double FinalBalance { get; set; }
        public DateTime FinalDate { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
    }
}
