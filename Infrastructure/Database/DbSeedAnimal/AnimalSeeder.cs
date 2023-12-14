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
                new Cat { Id = Guid.NewGuid(), Name = "Steven", LikesToPlay = true, Breed = "Siamese" },
                new Cat { Id = Guid.NewGuid(), Name = "Alpin", LikesToPlay = true, Breed = "Persian" },
                new Cat { Id = Guid.NewGuid(), Name = "Nelson", LikesToPlay = true, Breed = "Maine Coon" }
            );

            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Björn", LikesToPlay = true, Breed = "Labrador" },
                new Dog { Id = Guid.NewGuid(), Name = "Patrik", LikesToPlay = true, Breed = "Golden Retriever" },
                new Dog { Id = Guid.NewGuid(), Name = "Alfred", LikesToPlay = true, Breed = "German Shepherd" }
            );
        }
    }
}
