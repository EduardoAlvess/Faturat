using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TCC.Areas.Identity.Data
{
    public class User : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        //[Required]
        //public string UserName { get; set; }
        //[Required]
        //public string Password { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
