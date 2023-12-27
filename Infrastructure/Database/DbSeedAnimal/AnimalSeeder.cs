using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public static class AnimalSeeder
    {
        public static void SeedAnimals(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bird>().HasData(
                new Bird { Id = Guid.NewGuid(), Name = "Kiwi", TypeOfAnimal = "Bird", animalCanDo = "This animal can fly", LikesToPlay = true, Color = "Green" },
                new Bird { Id = Guid.NewGuid(), Name = "Sunshine", TypeOfAnimal = "Bird", animalCanDo = "This animal can fly", LikesToPlay = true, Color = "Yellow" },
                new Bird { Id = Guid.NewGuid(), Name = "Sky", TypeOfAnimal = "Bird", animalCanDo = "This animal can fly", LikesToPlay = true, Color = "Blue" },
                new Bird { Id = Guid.NewGuid(), Name = "Cherry", TypeOfAnimal = "Bird", animalCanDo = "This animal can fly", LikesToPlay = true, Color = "Red" },
                new Bird { Id = Guid.NewGuid(), Name = "Snowflake", TypeOfAnimal = "Bird", animalCanDo = "This animal can fly", LikesToPlay = true, Color = "White" }
            );


            modelBuilder.Entity<Cat>().HasData(
                new Cat { Id = Guid.NewGuid(), Name = "Whiskers", TypeOfAnimal = "Cat", animalCanDo = "This animal can meow", LikesToPlay = true, Breed = "Siamese", Weight = (int)8.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Mittens", TypeOfAnimal = "Cat", animalCanDo = "This animal can meow", LikesToPlay = true, Breed = "Persian", Weight = (int)10.5 },
                new Cat { Id = Guid.NewGuid(), Name = "Shadow", TypeOfAnimal = "Cat", animalCanDo = "This animal can meow", LikesToPlay = true, Breed = "Maine Coon", Weight = (int)15.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Smokey", TypeOfAnimal = "Cat", animalCanDo = "This animal can meow", LikesToPlay = true, Breed = "Ragdoll", Weight = (int)12.0 },
                new Cat { Id = Guid.NewGuid(), Name = "Tiger", TypeOfAnimal = "Cat", animalCanDo = "This animal can meow", LikesToPlay = true, Breed = "Bengal", Weight = (int)11.5 }
            );


            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = Guid.NewGuid(), Name = "Luna", TypeOfAnimal = "Dog", animalCanDo = "This animal can bark", LikesToPlay = true, Breed = "Labrador", Weight = (int)25.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Max", TypeOfAnimal = "Dog", animalCanDo = "This animal can bark", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)28.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Bella", TypeOfAnimal = "Dog", animalCanDo = "This animal can bark", LikesToPlay = true, Breed = "German Shepherd", Weight = (int)30.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Rocky", TypeOfAnimal = "Dog", animalCanDo = "This animal can bark", LikesToPlay = true, Breed = "Poodle", Weight = (int)15.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Daisy", TypeOfAnimal = "Dog", animalCanDo = "This animal can bark", LikesToPlay = true, Breed = "Beagle", Weight = (int)18.0 },
                new Dog { Id = Guid.NewGuid(), Name = "Riley", TypeOfAnimal = "Dog", animalCanDo = "This animal can bark", LikesToPlay = true, Breed = "Golden Retriever", Weight = (int)30.5 }
            );

            // Seed an admin user to Db.
            modelBuilder.Entity<User>().HasData(
                new User { Id = Guid.NewGuid(), Username = "admin", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin123!") }
                );
        }
    }
}
