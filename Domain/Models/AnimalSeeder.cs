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
                new Bird { Id = Guid.NewGuid(), Name = "Max", LikesToPlay = true },
                new Bird { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestCatForUnitTests", LikesToPlay = true },
                new Bird { Id = new Guid("12345678-1234-5678-1234-567812345671"), Name = "TestCatForUnitTests", LikesToPlay = true },
                new Bird { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestCatForUnitTests", LikesToPlay = true }
            );

            modelBuilder.Entity<Cat>().HasData(
                new Cat { Id = Guid.NewGuid(), Name = "Steven", LikesToPlay = true },
                new Cat { Id = Guid.NewGuid(), Name = "Alpin", LikesToPlay = true },
                new Cat { Id = Guid.NewGuid(), Name = "Nelson", LikesToPlay = true },
                new Cat { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestCatForUnitTests", LikesToPlay = true },
                new Cat { Id = new Guid("12345678-1234-5678-1234-567812345671"), Name = "TestCatForUnitTests", LikesToPlay = true },
                new Cat { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestCatForUnitTests", LikesToPlay = true }
            );

            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Björn", LikesToPlay = true },
                new Dog { Id = Guid.NewGuid(), Name = "Patrik", LikesToPlay = true },
                new Dog { Id = Guid.NewGuid(), Name = "Alfred", LikesToPlay = true },
                new Dog { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestDogForUnitTests", LikesToPlay = true },
                new Dog { Id = new Guid("12345678-1234-5678-1234-567812345671"), Name = "TestDogForUnitTests", LikesToPlay = true },
                new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests", LikesToPlay = true }
            );
        }
    }
}
