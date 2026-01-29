using Microsoft.AspNetCore.Identity;

namespace tp_5.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}