using Microsoft.AspNetCore.Identity;

namespace Pritz_API.Models
{
    public class ApplicationUser : IdentityUser

    {
        public string Name { get; set; }
    }
}
