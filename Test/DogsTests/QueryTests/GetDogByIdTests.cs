using Application.Queries.Dogs.GetById;
using Domain.Models;
using Infrastructure.Repositories.Dogs;
using Moq;

namespace Test.Dogs.QueryTests
{
    [TestFixture]
    public class GetDogByIdTests
    {
        private GetDogByIdQueryHandler _handler;
        private Mock<IDogRepository> _dogRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new GetDogByIdQueryHandler(_dogRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Dog> dogs)
        {
            _dogRepositoryMock.Setup(repo => repo.GetDogById(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((Guid dogId, CancellationToken cancellationToken) => dogs.FirstOrDefault(d => d.Id == dogId));
        }

        [Test]
        public async Task Handle_ValidId_ReturnsCorrectDog()
        {
            // Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345678");
            var dog = new List<Dog>
            {
                new Dog { Id = dogId }
            };

            SetupMockDbContext(dog);

            var query = new GetDogByIdQuery(dogId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.That(result.Id, Is.EqualTo(dogId));
        }

        [Test]
        public async Task Handle_InvalidId_ReturnsNull()
        {
            // Arrange
            var invalidDogId = Guid.NewGuid();

            // Empty list to simulate no matching bird
            SetupMockDbContext(new List<Dog>());

            var query = new GetDogByIdQuery(invalidDogId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
