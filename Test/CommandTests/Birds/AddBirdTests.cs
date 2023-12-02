using Application.Commands.Birds.AddBird;
using Application.Dtos;
using Infrastructure.Database;

namespace Test.CommandTests.Bird
{
    [TestFixture]
    public class AddBirdTests
    {
        private AddBirdCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _mockDatabase = new MockDatabase();
            _handler = new AddBirdCommandHandler(_mockDatabase);
        }


        [Test]
        public async Task Handle_ValidCommand_AddNewBird()
        {
            // Arrange
            var command = new AddBirdCommand(new BirdDto { Name = "NewBird" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNotNull(_mockDatabase.Birds.FirstOrDefault(bird => bird.Name == "NewBird"));
            Assert.That(_mockDatabase.Birds.FirstOrDefault(bird => bird.Name == "NewBird").Name, Is.EqualTo("NewBird"));

        }

        [Test]
        public async Task Handle_InValidCommand_EmptyBirdName()
        {
            // Arrange
            var command = new AddBirdCommand(new BirdDto { Name = "" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
