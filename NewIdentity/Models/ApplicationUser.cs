using Microsoft.AspNetCore.Identity;

namespace NewIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? City { get; set; }
       
    }
}
