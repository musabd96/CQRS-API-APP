using Application.Commands.Birds.DeleteBird;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.CommandTests.Birds
{
    [TestFixture]
    public class DeleteBirdByIdTests
    {
        private DeleteBirdByIdCommandHandler _handler;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new DeleteBirdByIdCommandHandler(_dbContextMock.Object);
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
        public async Task Handle_ValidId_DeletesBird()
        {
            // Arrange
            var birdId = new Guid("12345678-1234-5678-1234-567812345678");
            var bird = new List<Bird>
            {
                new Bird
                {
                    Id = birdId
                }
            };
            SetupMockDbContext(bird);

            var command = new DeleteBirdByIdCommand(birdId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(birdId));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidBirdId = Guid.NewGuid();
            var bird = new List<Bird>();
            SetupMockDbContext(bird);

            var command = new DeleteBirdByIdCommand(invalidBirdId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
