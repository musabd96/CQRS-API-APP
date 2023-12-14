using Domain.Models;
using Infrastructure.Database;
using Application.Queries.Birds.GetAll;
using Moq;
using Infrastructure.Repositories.Birds;

namespace Test.Birds.QueryTests
{
    [TestFixture]
    public class GetAllBirdsTests
    {
        private GetAllBirdsQueryHandler _handler;
        private GetAllBirdsQuery _request;
        private Mock<IBirdRepository> _birdRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new GetAllBirdsQueryHandler(_birdRepositoryMock.Object);
            _request = new GetAllBirdsQuery();
        }

        protected void SetupMockDbContext(List<Bird> birds)
        {
            _birdRepositoryMock.Setup(repo => repo.GetAllBirds(It.IsAny<CancellationToken>()))
                .ReturnsAsync(birds);
        }

        [Test]
        public async Task Handle_ValidRequest_ReturnsListOfBirds()
        {
            // Arrange
            var birdsList = new List<Bird>
            {
                new Bird { Id = Guid.NewGuid(), Name = "Sparrow" },
                new Bird { Id = Guid.NewGuid(), Name = "Robin" }
            };

            SetupMockDbContext(birdsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(birdsList.Count));
        }

        [Test]
        public async Task Handle_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var emptyBirdsList = new List<Bird>();
            SetupMockDbContext(emptyBirdsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsEmpty(result);
        }


    }
}
