

using Application.Commands.Dogs;
using Application.Dtos;
using Infrastructure.Database;

namespace Test.DogTests.CommandTest
{
    [TestFixture]
    public class AddDogCommandHandlerTests
    {
        private AddDogCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the handler and mock database before each test
            _mockDatabase = new MockDatabase();
            _handler = new Application.Commands.Dogs.AddDogCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidCommand_AddNewDog()
        {
            // Arrange
            var command = new AddDogCommand(new DogDto { Name = "NewDog" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            var newDogInDatabase = _mockDatabase.Dogs.FirstOrDefault(dog => dog.Name == "NewDog");

            Assert.IsNotNull(newDogInDatabase);
            Assert.That(newDogInDatabase.Name, Is.EqualTo("NewDog"));
        }

        [Test]
        public async Task Handle_InValidCommand_EmptyDogName()
        {
            // Arrange
            var command = new AddDogCommand(new DogDto { Name = "" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }



    }
}
