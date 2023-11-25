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


        private static List<Dog> allDogs = new()
        {
            new Dog { Id = Guid.NewGuid(), Name = "Björn"},
            new Dog { Id = Guid.NewGuid(), Name = "Patrik"},
            new Dog { Id = Guid.NewGuid(), Name = "Alfred"},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestDogForUnitTests"},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345671"), Name = "TestDogForUnitTests"},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests"}
        };

        private static List<Cat> allCats = new()
        {
            new Cat { Id = Guid.NewGuid(), Name = "Steven"},
            new Cat { Id = Guid.NewGuid(), Name = "Alpin"},
            new Cat { Id = Guid.NewGuid(), Name = "Nelson"},
            new Cat { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestCatForUnitTests"},
            new Cat { Id = new Guid("12345678-1234-5678-1234-567812345671"), Name = "TestCatForUnitTests"},
            new Cat { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestCatForUnitTests"}
        };


        public object Clone()
        {
            MockDatabase clone = new MockDatabase
            {
                Dogs = new List<Dog>(Dogs),
                Cats = new List<Cat>(Cats)
            };

            return clone;
        }
    }
}
