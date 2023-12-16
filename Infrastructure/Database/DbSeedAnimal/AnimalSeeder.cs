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
                new Cat { Id = Guid.NewGuid(), Name = "Steven", LikesToPlay = true, Breed = "Siamese", Weight = 5 },
                new Cat { Id = Guid.NewGuid(), Name = "Alpin", LikesToPlay = true, Breed = "Persian", Weight = 4 },
                new Cat { Id = Guid.NewGuid(), Name = "Nelson", LikesToPlay = true, Breed = "Maine Coon", Weight = 7 }
            );

            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Björn", LikesToPlay = true, Breed = "Labrador", Weight = 25 },
                new Dog { Id = Guid.NewGuid(), Name = "Patrik", LikesToPlay = true, Breed = "Golden Retriever", Weight = 30 },
                new Dog { Id = Guid.NewGuid(), Name = "Alfred", LikesToPlay = true, Breed = "German Shepherd", Weight = 22 }
            );

        }
    }
}
