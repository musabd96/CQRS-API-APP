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
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new AddBirdCommandHandler(_originalDatabase);
        }


        [Test]
        public async Task Handle_ValidCommand_AddNewBird()
        {
            // Arrange
            var command = new AddBirdCommand(new BirdDto { Name = "NewBird" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            var newBirdInDatabase = _mockDatabase.Birds.FirstOrDefault(bird => bird.Name == "NewBird");

            Assert.IsNotNull(newBirdInDatabase);
            Assert.That(newBirdInDatabase.Name, Is.EqualTo("NewBird"));
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
