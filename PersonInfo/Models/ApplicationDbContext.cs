using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace PersonInfo.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Semat> Semats { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}