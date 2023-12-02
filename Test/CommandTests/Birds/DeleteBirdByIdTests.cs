using Application.Commands.Birds.DeleteBird;
using Infrastructure.Database;

namespace Test.CommandTests.Bird
{
    [TestFixture]
    public class DeleteBirdByIdTests
    {
        private DeleteBirdByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _mockDatabase = new MockDatabase();
            _handler = new DeleteBirdByIdCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidId_DeletesBird()
        {
            // Arrange
            var birdId = new Guid("12345678-1234-5678-1234-567812345670");

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

            var command = new DeleteBirdByIdCommand(invalidBirdId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
