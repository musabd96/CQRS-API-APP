using Application.Commands.Birds.UpdateBird;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.CommandTests.Birds
{
    [TestFixture]
    public class UpdateBirdTests
    {
        private UpdateBirdByIdCommandHandler _handler;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new UpdateBirdByIdCommandHandler(_dbContextMock.Object);
        }

        protected void SetupMockDbContext(List<Bird> birds)
        {
            var mockDbSet = new Mock<DbSet<Bird>>();
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.Provider).Returns(birds.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.Expression).Returns(birds.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.ElementType).Returns(birds.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.GetEnumerator()).Returns(birds.GetEnumerator());

            _dbContextMock.Setup(b => b.Birds).Returns(mockDbSet.Object);
        }

        [Test]
        public async Task Handle_ValidId_UpdatesBird()
        {
            // Arrange
            var birdId = new Guid("12345678-1234-5678-1234-567812345678");
            var birdsList = new List<Bird>
            {
                new Bird
                {
                    Id = birdId,
                    Name = "Nelson",
                    LikesToPlay = true
                }
            };
            SetupMockDbContext(birdsList);

            var updatedName = new BirdDto { Name = "NewCatName", LikesToPlay = false };

            var command = new UpdateBirdByIdCommand(updatedName, birdId);

            // Act
            await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(updatedName.Name, Is.EqualTo(command.UpdatedBird.Name));
        }

        [Test]
        public async Task Handle_InvalidId_ReturnsNull()
        {
            // Arrange
            var invalidBirdId = Guid.NewGuid();
            var birdsList = new List<Bird>
            {
                new Bird
                {
                    Id = Guid.NewGuid(),
                    Name = "Nelson",
                    LikesToPlay = true
                }
            };
            SetupMockDbContext(birdsList);

            var updatedName = new BirdDto { Name = "NewCatName", LikesToPlay = false };

            var command = new UpdateBirdByIdCommand(updatedName, invalidBirdId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }

    }
}
