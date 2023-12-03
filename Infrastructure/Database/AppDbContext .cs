using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Bird> Birds { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=100.112.149.77;Port=3306;Database=API_Animals;User=nageye;Password=mustafa0909;";

            optionsBuilder.UseMySql(connectionString, new MariaDbServerVersion(new Version(10, 5, 12)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Call the SeedAnimals method to populate the data
            AnimalSeeder.SeedAnimals(modelBuilder);
        }

        public AppDbContext Clone()
        {
            // Create a new instance of AppDbContext
            var clone = new AppDbContext();

            // Copy data from the original context to the clone
            clone.Dogs.AddRange(Dogs.ToList());
            clone.Cats.AddRange(Cats.ToList());
            clone.Birds.AddRange(Birds.ToList());

            // Note: You may need to handle other DbSet properties if you have more in your actual DbContext

            return clone;
        }

    }
}
