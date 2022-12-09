using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TCC.Areas.Identity.Data
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
