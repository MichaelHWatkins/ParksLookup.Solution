using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
    public class ParksLookupContext : DbContext
    {
        public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 1, ParkName = "Grand Canyon"},
              new Park { ParkId = 2, ParkName = "Mt. Rainer"}
              
          );
        }
        public DbSet<Park> Parks { get; set; }
    }
}