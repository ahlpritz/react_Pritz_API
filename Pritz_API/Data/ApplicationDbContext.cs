using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pritz_API.Models;

namespace Pritz_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }

    }
       
}
