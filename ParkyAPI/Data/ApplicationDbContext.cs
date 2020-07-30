using Microsoft.EntityFrameworkCore;
using ParkyAPI.Model.Entity;

namespace ParkyAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<NationalPark> NationalPark { get; set; }
        public DbSet<Trail> Trail { get; set; }
    }
}
