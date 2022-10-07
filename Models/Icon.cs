using System.ComponentModel.DataAnnotations;

namespace TCC.Models
{
    public class Icon
    {
        [Key]
        public int Id { get; set; }
        public string ImageName { get; set; }
    }
}
