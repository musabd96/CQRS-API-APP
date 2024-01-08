using Application.Queries.Birds.GetById;
using Domain.Models;
using Infrastructure.Repositories.Birds;
using Moq;

namespace Test.Birds.QueryTests
{
    [TestFixture]
    public class GetBirdByIdTests
    {
        private GetBirdByIdQueryHandler _handler;
        private Mock<IBirdRepository> _birdRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new GetBirdByIdQueryHandler(_birdRepositoryMock.Object);
        }
        protected void SetupMockDbContext(List<Bird> birds)
        {
            _birdRepositoryMock.Setup(repo => repo.GetBirdById(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((Guid dogId, CancellationToken cancellationToken) => birds.FirstOrDefault(d => d.Id == dogId));
        }

        [Test]
        public async Task Handle_ValidId_ReturnsCorrectBird()
        {
            // Arrange
            var birdId = new Guid("12345678-1234-5678-1234-567812345678");
            var bird = new List<Bird>
            {
                new Bird { Id = birdId }
            };

            SetupMockDbContext(bird);

            var query = new GetBirdByIdQuery(birdId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.That(result.Id, Is.EqualTo(birdId));
        }

        [Test]
        public async Task Handle_InvalidId_ReturnsNull()
        {
            // Arrange
            var invalidBirdId = Guid.NewGuid();

            // Empty list to simulate no matching bird
            SetupMockDbContext(new List<Bird>());

            var query = new GetBirdByIdQuery(invalidBirdId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
