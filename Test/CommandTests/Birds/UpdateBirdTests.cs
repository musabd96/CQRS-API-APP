using Application.Commands.Birds.UpdateBird;
using Application.Dtos;
using Infrastructure.Database;

namespace Test.CommandTests.Birds
{
    [TestFixture]
    public class UpdateBirdTests
    {
        private UpdateBirdByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _mockDatabase = new MockDatabase();
            _handler = new UpdateBirdByIdCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidId_UpdatesBird()
        {
            // Arrange
            var birdId = new Guid("12345678-1234-5678-1234-567812345678");
            var updatedName = new BirdDto { Name = "NewBirdName", LikesToPlay = false };

            var command = new UpdateBirdByIdCommand(updatedName, birdId);

            //Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Name, Is.EqualTo("NewBirdName"));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidBirdId = Guid.NewGuid();
            var invalidBirdName = new BirdDto { Name = "Name" };

            // Mock the database to simulate that no bird with the specified ID is found
            var mockDatabase = new MockDatabase();
            var handler = new UpdateBirdByIdCommandHandler(mockDatabase);

            var command = new UpdateBirdByIdCommand(invalidBirdName, invalidBirdId);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result, "The result should be null for an invalid cat ID.");
        }
    }
}
