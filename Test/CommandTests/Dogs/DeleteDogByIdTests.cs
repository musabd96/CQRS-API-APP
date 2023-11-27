using Application.Commands.Dogs.DeleteDog;
using Application.Commands.Dogs.UpdateDog;
using Infrastructure.Database;

namespace Test.CommandTest.Dogs
{
    [TestFixture]
    public class DeleteDogByIdTest
    {
        private DeleteDogByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new DeleteDogByIdCommandHandler(_originalDatabase);
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

