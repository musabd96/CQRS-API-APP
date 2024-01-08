using Application.Queries.Birds.GetByColor;
using Domain.Models;
using Infrastructure.Repositories.Birds;
using Moq;

namespace Test.Birds.QueryTests
{
    [TestFixture]
    public class GetBirdsByColorTests
    {
        private GetAllCatsByColorQueryHandler _handler;
        private Mock<IBirdRepository> _birdRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new GetAllCatsByColorQueryHandler(_birdRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Bird> birds)
        {
            _birdRepositoryMock.Setup(repo => repo.GetAllBirdsByColor(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                             .ReturnsAsync((string color, CancellationToken cancellationToken) =>
                             {
                                 return birds.FindAll(b => b.Color == color);
                             });
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllBirdsByColor()
        {
            // Arrange
            var birdsList = new List<Bird>
            {
                new Bird { Id = Guid.NewGuid(),Name = "Sky", Color = "Blue" },
                new Bird { Id = Guid.NewGuid(),Name = "B", Color = "Blue" }
            };
            SetupMockDbContext(birdsList);
            var color = "Blue";

            //Act
            var result = await _handler.Handle(new GetAllCatsByColorQuery(color), CancellationToken.None);

            //Assert
            Assert.That(result, Is.EqualTo(birdsList));
        }
        [Test]
        public async Task Handle_InValid_ReturnsEmptyList()
        {
            // Arrange
            var birdsList = new List<Bird>
            {
                new Bird { Id = Guid.NewGuid(),Name = "Sky", Color = "Blue" },
                new Bird { Id = Guid.NewGuid(),Name = "B", Color = "Blue" }
            };
            SetupMockDbContext(birdsList);
            var InvalidColor = "InvalidColor";

            //Act
            var result = await _handler.Handle(new GetAllCatsByColorQuery(InvalidColor), CancellationToken.None);

            //Assert
            Assert.That(result, Is.Empty);
        }
    }
}
