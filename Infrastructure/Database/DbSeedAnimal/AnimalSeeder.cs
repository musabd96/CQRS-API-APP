using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public static class AnimalSeeder
    {
        public static void SeedAnimals(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bird>().HasData(
                new Bird { Id = Guid.NewGuid(), Name = "Kiwi", LikesToPlay = true, Color = "Green" },
                new Bird { Id = Guid.NewGuid(), Name = "Sunshine", LikesToPlay = true, Color = "Yellow" },
                new Bird { Id = Guid.NewGuid(), Name = "Sky", LikesToPlay = true, Color = "Blue" },
                new Bird { Id = Guid.NewGuid(), Name = "Cherry", LikesToPlay = true, Color = "Red" },
                new Bird { Id = Guid.NewGuid(), Name = "Snowflake", LikesToPlay = true, Color = "White" }
            );


            modelBuilder.Entity<Cat>().HasData(
                new Cat { Id = Guid.NewGuid(), Name = "Whiskers", LikesToPlay = true, Breed = "Siamese", Weight = (int)8.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Mittens", LikesToPlay = true, Breed = "Persian", Weight = (int)10.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Shadow", LikesToPlay = true, Breed = "Maine Coon", Weight = (int)15.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Smokey", LikesToPlay = true, Breed = "Ragdoll", Weight = (int)12.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Tiger", LikesToPlay = true, Breed = "Bengal", Weight = (int)11.5 }
            );


            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Luna", LikesToPlay = true, Breed = "Labrador", Weight = (int)25.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Max", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)28.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Bella", LikesToPlay = true, Breed = "German Shepherd", Weight = (int)30.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Rocky", LikesToPlay = true, Breed = "Poodle", Weight = (int)15.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Daisy", LikesToPlay = true, Breed = "Beagle", Weight = (int)18.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Riley", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)30.5 }
            );

        }
    }
}
