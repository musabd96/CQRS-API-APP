using Application.Commands.Dogs.UpdateDog;
using Application.Dtos;
using Application.Queries.Dogs.GetById;
using Infrastructure.Database;

namespace Test.CommandTest.Dogs
{
    [TestFixture]
    public class UpdateDogTests
    {
        private UpdateDogByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new UpdateDogByIdCommandHandler(_originalDatabase);
        }

        [Test]
        public async Task Handle_ValidId_UpdatesDog()
        {
            // Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345678");
            var updatedName = new DogDto { Name = "NewDogName" };

            var command = new UpdateDogByIdCommand(updatedName, dogId);

            //Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Name, Is.EqualTo("NewDogName"));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidDogId = Guid.NewGuid();
            var invalidDogName = new DogDto { Name = "Name" };

            // Mock the database to simulate that no dog with the specified ID is found
            var mockDatabase = new MockDatabase();
            var handler = new UpdateDogByIdCommandHandler(mockDatabase);

            var command = new UpdateDogByIdCommand(invalidDogName, invalidDogId);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result, "The result should be null for an invalid dog ID.");
        }

    }
}
