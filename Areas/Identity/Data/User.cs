using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace TCC.Areas.Identity.Data
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public bool isDeleted { get; set; } = false;
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
