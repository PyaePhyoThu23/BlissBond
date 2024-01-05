using Microsoft.AspNetCore.Identity;

namespace BlissBond.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
    }
}