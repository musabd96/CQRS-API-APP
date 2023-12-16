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
                new Cat { Id = Guid.NewGuid(), Name = "Whiskers", LikesToPlay = true, Breed = "Siamese", Weight = (int)8.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Mittens", LikesToPlay = true, Breed = "Persian", Weight = (int)10.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Shadow", LikesToPlay = true, Breed = "Maine Coon", Weight = (int)15.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Smokey", LikesToPlay = true, Breed = "Ragdoll", Weight = (int)12.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Tiger", LikesToPlay = true, Breed = "Bengal", Weight = (int)11.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Luna", LikesToPlay = true, Breed = "Siamese", Weight = (int)7.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Oreo", LikesToPlay = true, Breed = "Persian", Weight = (int)9.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Leo", LikesToPlay = true, Breed = "Maine Coon", Weight = (int)14.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Cleo", LikesToPlay = true, Breed = "Ragdoll", Weight = (int)11.8 },
                new Cat { Id = Guid.NewGuid(), Name = "Simba", LikesToPlay = true, Breed = "Bengal", Weight = (int)10.2 },
                new Cat { Id = Guid.NewGuid(), Name = "Misty", LikesToPlay = true, Breed = "Siamese", Weight = (int)8.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Salem", LikesToPlay = true, Breed = "Persian", Weight = (int)10.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Oliver", LikesToPlay = true, Breed = "Maine Coon", Weight = (int)16.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Whiskey", LikesToPlay = true, Breed = "Ragdoll", Weight = (int)12.3 },
                new Cat { Id = Guid.NewGuid(), Name = "Milo", LikesToPlay = true, Breed = "Bengal", Weight = (int)9.8 },
                new Cat { Id = Guid.NewGuid(), Name = "Lola", LikesToPlay = true, Breed = "Siamese", Weight = (int)7.8 },
                new Cat { Id = Guid.NewGuid(), Name = "Casper", LikesToPlay = true, Breed = "Persian", Weight = (int)11.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Nala", LikesToPlay = true, Breed = "Maine Coon", Weight = (int)13.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Mocha", LikesToPlay = true, Breed = "Ragdoll", Weight = (int)11.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Charlie", LikesToPlay = true, Breed = "Bengal", Weight = (int)10.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Whisper", LikesToPlay = true, Breed = "Siamese", Weight = (int)8.2 },
                new Cat { Id = Guid.NewGuid(), Name = "Gizmo", LikesToPlay = true, Breed = "Persian", Weight = (int)9.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Mittens", LikesToPlay = true, Breed = "Maine Coon", Weight = (int)14.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Ziggy", LikesToPlay = true, Breed = "Ragdoll", Weight = (int)12.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Sasha", LikesToPlay = true, Breed = "Bengal", Weight = (int)9.0 }
            );


            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Luna", LikesToPlay = true, Breed = "Labrador", Weight = (int)25.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Max", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)28.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Bella", LikesToPlay = true, Breed = "German Shepherd", Weight = (int)30.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Rocky", LikesToPlay = true, Breed = "Poodle", Weight = (int)15.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Daisy", LikesToPlay = true, Breed = "Beagle", Weight = (int)18.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Charlie", LikesToPlay = true, Breed = "Labrador", Weight = (int)22.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Coco", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)27.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Milo", LikesToPlay = true, Breed = "German Shepherd", Weight = (int)28.5 },
                new Dog { Id = Guid.NewGuid(), Name = "Rosie", LikesToPlay = true, Breed = "Poodle", Weight = (int)14.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Zeus", LikesToPlay = true, Breed = "Beagle", Weight = (int)20.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Sadie", LikesToPlay = true, Breed = "Labrador", Weight = (int)25.5 },
                new Dog { Id = Guid.NewGuid(), Name = "Duke", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)29.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Chloe", LikesToPlay = true, Breed = "German Shepherd", Weight = (int)31.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Oliver", LikesToPlay = true, Breed = "Poodle", Weight = (int)16.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Ruby", LikesToPlay = true, Breed = "Beagle", Weight = (int)19.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Thor", LikesToPlay = true, Breed = "Labrador", Weight = (int)23.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Pepper", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)26.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Cooper", LikesToPlay = true, Breed = "Labrador", Weight = (int)24.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Mia", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)29.5 },
                new Dog { Id = Guid.NewGuid(), Name = "Tucker", LikesToPlay = true, Breed = "German Shepherd", Weight = (int)32.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Sophie", LikesToPlay = true, Breed = "Poodle", Weight = (int)17.5 },
                new Dog { Id = Guid.NewGuid(), Name = "Leo", LikesToPlay = true, Breed = "Beagle", Weight = (int)21.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Lucy", LikesToPlay = true, Breed = "Labrador", Weight = (int)26.5 },
                new Dog { Id = Guid.NewGuid(), Name = "Riley", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)30.5 }
            );

        }
    }
}
