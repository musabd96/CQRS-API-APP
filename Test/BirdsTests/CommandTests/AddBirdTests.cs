using Application.Commands.Birds.AddBird;
using Application.Dtos.AnimalDto;
using Application.Validators.Bird;
using Domain.Models;
using Infrastructure.Repositories.Birds;
using Moq;

namespace Test.Birds.CommandTests
{
    [TestFixture]
    public class AddBirdTests
    {
        private AddBirdCommandHandler _handler;
        private Mock<IBirdRepository> _birdRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _birdRepositoryMock = new Mock<IBirdRepository>();
            _handler = new AddBirdCommandHandler(_birdRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Bird> birds)
        {
            _birdRepositoryMock.Setup(repo => repo.AddBird(It.IsAny<Bird>(), It.IsAny<CancellationToken>()))
                .Callback((Bird bird, CancellationToken cancellationToken) => birds.Add(bird))
                .Returns((Bird bird, CancellationToken cancellationToken) => Task.FromResult(bird));
        }

        [Test]
        public async Task Handle_ValidCommand_AddNewBird()
        {
            // Arrange
            var birds = new List<Bird>();
            SetupMockDbContext(birds);

            var command = new AddBirdCommand(new BirdDto { Name = "NewBird" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(result.Name, Is.EqualTo("NewBird"));
        }

        [Test]
        public async Task Handle_InValidCommand_EmptyDogName()
        {
            // Arrange
            var validator = new BirdValidator();
            var birdName = new BirdDto { Name = "" };

            // Act
            var result = await Task.FromResult(validator.Validate(birdName));

            // Assert
            Assert.That(result.Errors.Single().ErrorMessage, Is.EqualTo("Bird Name can not be empty"));
        }
    }
}
