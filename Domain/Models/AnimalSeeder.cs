using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public static class AnimalSeeder
    {
        public static void SeedAnimals(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bird>().HasData(
                new Bird { Id = Guid.NewGuid(), Name = "Alex", LikesToPlay = true },
                new Bird { Id = Guid.NewGuid(), Name = "Sofia", LikesToPlay = true },
                new Bird { Id = Guid.NewGuid(), Name = "Max", LikesToPlay = true }
            );

            modelBuilder.Entity<Cat>().HasData(
                new Cat { Id = Guid.NewGuid(), Name = "Steven", LikesToPlay = true },
                new Cat { Id = Guid.NewGuid(), Name = "Alpin", LikesToPlay = true },
                new Cat { Id = Guid.NewGuid(), Name = "Nelson", LikesToPlay = true }
            );

            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Björn", LikesToPlay = true },
                new Dog { Id = Guid.NewGuid(), Name = "Patrik", LikesToPlay = true },
                new Dog { Id = Guid.NewGuid(), Name = "Alfred", LikesToPlay = true }
            );
        }
    }
}
