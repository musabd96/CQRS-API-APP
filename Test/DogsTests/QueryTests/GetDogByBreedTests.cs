using Infrastructure.Repositories.Dogs;
using Moq;
using Application.Queries.Dogs.GetbyBreed;
using Domain.Models;

namespace Test.DogsTests.QueryTests
{
    [TestFixture]
    public class GetDogByBreedTests
    {
        private GetAllDogsByBreedQueryHandler _handler;
        private Mock<IDogRepository> _dogRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new GetAllDogsByBreedQueryHandler(_dogRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Dog> dogs)
        {
            _dogRepositoryMock.Setup(repo => repo.GetAllDogsByBreed(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                             .ReturnsAsync((string breed, CancellationToken cancellationToken) =>
                             {
                                 return dogs.FindAll(d => d.Breed == breed);
                             });
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllDogsByBreed()
        {
            // Arrange
            var dogsList = new List<Dog>
            {
                new Dog { Id = Guid.NewGuid(),Name = "Buddy", Breed = "Labrador" },
                new Dog { Id = Guid.NewGuid(),Name = "Joe", Breed = "Labrador" }
            };
            SetupMockDbContext(dogsList);
            var breed = "Labrador";

            //Act
            var result = await _handler.Handle(new GetAllDogsByBreedQuery(breed), CancellationToken.None);

            //Assert
            Assert.That(result, Is.EqualTo(dogsList));
        }
        [Test]
        public async Task Handle_InValid_ReturnsEmptyList()
        {
            // Arrange
            var dogsList = new List<Dog>
            {
                new Dog { Id = Guid.NewGuid(),Name = "Buddy", Breed = "Labrador" },
                new Dog { Id = Guid.NewGuid(),Name = "Joe", Breed = "Labrador" }
            };
            SetupMockDbContext(dogsList);
            var InvalidBreed = "InvalidBreed";

            //Act
            var result = await _handler.Handle(new GetAllDogsByBreedQuery(InvalidBreed), CancellationToken.None);

            //Assert
            Assert.That(result, Is.Empty);
        }
    }
}
