using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int IconId { get; set; }
        public string Name { get; set; }
        public double CurrentAmount { get; set; }
        public double FinalAmount { get; set; }
        public DateTime FinalDate { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
