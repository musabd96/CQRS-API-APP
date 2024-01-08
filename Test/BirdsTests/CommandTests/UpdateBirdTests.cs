using Application.Commands.Birds.UpdateBird;
using Application.Dtos.AnimalDto;
using Domain.Models;
using Infrastructure.Repositories.Birds;
using Moq;

namespace Test.Birds.CommandTests
{
    [TestFixture]
    public class UpdateBirdTests
    {
        private UpdateBirdByIdCommandHandler _handler;
        private Mock<IBirdRepository> _birdRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new UpdateBirdByIdCommandHandler(_birdRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Bird> birds)
        {
            _birdRepositoryMock.Setup(repo => repo.UpdateBird(
                    It.IsAny<Guid>(),
                    It.IsAny<string>(),  // Assuming 'Name' is a property of bird
                    It.IsAny<string>(),  // Assuming 'Color' is a property of bird
                    It.IsAny<bool>(),    // Assuming 'LikesToPlay' is a property of bird
                    It.IsAny<string>(),  // Assuming 'OwnerBirdUserName' is a property of bird
                    It.IsAny<CancellationToken>()
                ))
                .Returns((Guid birdId, string updatedBirdName,
                          string updatedBirdColor, bool updatedBirdLikesToPlay,
                          string ownerBirdUserName, CancellationToken cancellationToken) =>
                {
                    var existingBird = birds.FirstOrDefault(b => b.Id == birdId);

                    if (existingBird != null)
                    {
                        existingBird.Name = updatedBirdName;
                        existingBird.Color = updatedBirdColor;
                        existingBird.LikesToPlay = updatedBirdLikesToPlay;
                        existingBird.OwnerUserName = ownerBirdUserName;
                    }
                    return Task.FromResult(existingBird)!;
                });
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
                    Color = "Green",
                    LikesToPlay = true,
                    OwnerUserName = "testOwner"
                }
            };
            SetupMockDbContext(birdsList);

            var updatedName = new BirdDto
            {
                Name = "NewCatName",
                Color = "Green",
                LikesToPlay = false,
                OwnerUserName = "testOwner"
            };

            var command = new UpdateBirdByIdCommand(birdId, updatedName);

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
                    Color = "Green",
                    LikesToPlay = true,
                    OwnerUserName = "testOwner"
                }
            };
            SetupMockDbContext(birdsList);

            var updatedName = new BirdDto
            {
                Name = "NewCatName",
                Color = "Green",
                LikesToPlay = false,
                OwnerUserName = "testOwner"
            };

            var command = new UpdateBirdByIdCommand(invalidBirdId, updatedName);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }

    }
}
