using Domain.Models;

namespace Infrastructure.Database
{
    public class MockDatabase : ICloneable
    {
        public List<Dog> Dogs
        {
            get { return allDogs; }
            set { allDogs = value; }
        }
        public List<Cat> Cats
        {
            get { return allCats; }
            set { allCats = value; }
        }

        public List<Bird> Birds
        {
            get { return allBirds; }
            set { allBirds = value; }
        }

        private static List<Dog> allDogs = new()
        {
            new Dog { Id = Guid.NewGuid(), Name = "Björn", LikesToPlay = true},
            new Dog { Id = Guid.NewGuid(), Name = "Patrik", LikesToPlay = true},
            new Dog { Id = Guid.NewGuid(), Name = "Alfred", LikesToPlay = true},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestDogForUnitTests", LikesToPlay = true},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345671"), Name = "TestDogForUnitTests", LikesToPlay = true},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests", LikesToPlay = true}
        };

        private static List<Cat> allCats = new()
        {
            new Cat { Id = Guid.NewGuid(), Name = "Steven", LikesToPlay = true},
            new Cat { Id = Guid.NewGuid(), Name = "Alpin", LikesToPlay = true},
            new Cat { Id = Guid.NewGuid(), Name = "Nelson", LikesToPlay = true},
            new Cat { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestCatForUnitTests", LikesToPlay = true},
            new Cat { Id = new Guid("12345678-1234-5678-1234-567812345671"), Name = "TestCatForUnitTests", LikesToPlay = true},
            new Cat { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestCatForUnitTests", LikesToPlay = true}
        };

        private static List<Bird> allBirds = new()
        {
            new Bird { Id = Guid.NewGuid(), Name = "Alex", LikesToPlay = true},
            new Bird { Id = Guid.NewGuid(), Name = "Sofia", LikesToPlay = true},
            new Bird { Id = Guid.NewGuid(), Name = "Max", LikesToPlay = true},
            new Bird { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestCatForUnitTests", LikesToPlay = true},
            new Bird { Id = new Guid("12345678-1234-5678-1234-567812345671"), Name = "TestCatForUnitTests", LikesToPlay = true},
            new Bird { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestCatForUnitTests", LikesToPlay = true}
        };


        public object Clone()
        {
            MockDatabase clone = new MockDatabase
            {
                Dogs = new List<Dog>(Dogs),
                Cats = new List<Cat>(Cats),
                Birds = new List<Bird>(Birds)
            };

            return clone;
        }
    }
}
