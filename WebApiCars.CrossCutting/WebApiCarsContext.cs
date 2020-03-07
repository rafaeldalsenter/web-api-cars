using Microsoft.EntityFrameworkCore;
using WebApiCars.Domain;

namespace WebApiCars.CrossCutting
{
    public class WebApiCarsContext : DbContext
    {
        public WebApiCarsContext(DbContextOptions options) :
            base(options)
        { }

        public DbSet<AutoMaker> AutoMakers { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoMaker>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<Car>()
                .HasKey(p => p.Id);
        }
    }
}