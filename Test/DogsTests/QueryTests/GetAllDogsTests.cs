using Application.Queries.Dogs.GetAll;
using Domain.Models;
using Application.Queries.Dogs;
using Moq;
using Infrastructure.Repositories.Dogs;

namespace Test.Dogs.QueryTests
{
    [TestFixture]
    public class GetAllDogsTests
    {
        private GetAllDogsQueryHandler _handler;
        private GetAllDogsQuery _request;
        private Mock<IDogRepository> _dogRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new GetAllDogsQueryHandler(_dogRepositoryMock.Object);
            _request = new GetAllDogsQuery();
        }

        protected void SetupMockDbContext(List<Dog> dogs)
        {
            _dogRepositoryMock.Setup(repo => repo.GetAllDogs(It.IsAny<CancellationToken>()))
                .ReturnsAsync(dogs);
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllDogs()
        {
            // Arrange
            var dogsList = new List<Dog>
            {
                new Dog { Id = Guid.NewGuid(), Name = "Sparrow" },
                new Dog { Id = Guid.NewGuid(), Name = "Robin" }
            };

            SetupMockDbContext(dogsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(dogsList.Count));
        }

        [Test]
        public async Task Handle_InvalidDatabase_ReturnsNullOrEmptyList()
        {
            // Arrange
            var emptyDogsList = new List<Dog>();
            SetupMockDbContext(emptyDogsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsEmpty(result);
        }
    }
}
