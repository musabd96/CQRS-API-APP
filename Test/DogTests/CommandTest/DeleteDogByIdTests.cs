using Application.Commands.Dogs.DeleteDog;
using Infrastructure.Database;

namespace Test.DogTests.CommandTest
{
    [TestFixture]
    public class DeleteDogByIdTest
    {
        private DeleteDogByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the handler and mock database before each test
            _mockDatabase = new MockDatabase();
            _handler = new DeleteDogByIdCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidId_DeletesDog()
        {
            // Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345670");

            var command = new DeleteDogByIdCommand(dogId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(dogId));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidDogId = Guid.NewGuid();

            var command = new DeleteDogByIdCommand(invalidDogId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}

