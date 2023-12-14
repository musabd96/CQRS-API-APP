using Application.Commands.Birds.AddBird;
using Application.Commands.Birds.DeleteBird;
using Domain.Models;
using Infrastructure.Database;
using Infrastructure.Repositories.Birds;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.Birds.CommandTests
{
    [TestFixture]
    public class DeleteBirdByIdTests
    {
        private DeleteBirdByIdCommandHandler _handler;
        private Mock<IBirdRepository> _birdRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new DeleteBirdByIdCommandHandler(_birdRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Bird> birds)
        {
            _birdRepositoryMock.Setup(repo => repo.DeleteBird(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                .Returns((Guid birdId, CancellationToken cancellationToken) =>
                {
                    var birdToDelete = birds.FirstOrDefault(bird => bird.Id == birdId);

                    return Task.FromResult<Bird>(null!);
                });
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
            Assert.Null(result);
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
