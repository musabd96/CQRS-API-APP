using Infrastructure.Repositories.Dogs;
using Moq;
using Application.Queries.Dogs.GetbyBreed;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Test.Dogs.QueryTests
{
    [TestFixture]
    public class GetDogsByCriteriaTests
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
            _dogRepositoryMock.Setup(repo => repo.GetAllDogsByCriteria(
                It.IsAny<string>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync((string breed, int weight, CancellationToken cancellationToken) =>
                {
                    return dogs.Where(d => (string.IsNullOrEmpty(breed) || d.Breed == breed) &&
                                           (weight == 0 || d.Weight >= weight)).ToList();
                });
        }


        [Test]
        public async Task Handle_Valid_ReturnsAllDogsByBreed()
        {
            // Arrange
            var dogsList = new List<Dog>
            {
                new Dog { Id = Guid.NewGuid(),Name = "Buddy", Breed = "Labrador", Weight = 9 },
                new Dog { Id = Guid.NewGuid(),Name = "Joe", Breed = "Labrador", Weight = 9 }
            };
            SetupMockDbContext(dogsList);
            var breed = "Labrador";
            var weight = 9;

            //Act
            var result = await _handler.Handle(new GetAllDogsByCriteriaQuery(breed, weight), CancellationToken.None);

            //Assert
            Assert.That(result, Is.EqualTo(dogsList));
        }
        [Test]
        public async Task Handle_InValid_ReturnsEmptyList()
        {
            // Arrange
            var dogsList = new List<Dog>
            {
                new Dog { Id = Guid.NewGuid(),Name = "Buddy", Breed = "Labrador", Weight = 9 },
                new Dog { Id = Guid.NewGuid(),Name = "Joe", Breed = "Labrador", Weight = 9 }
            };
            SetupMockDbContext(dogsList);
            var invalidBreed = "InvalidBreed";
            var invalidWeight = 10;

            //Act
            var result = await _handler.Handle(new GetAllDogsByCriteriaQuery(invalidBreed, invalidWeight), CancellationToken.None);

            //Assert
            Assert.That(result, Is.Empty);
        }
    }
}
