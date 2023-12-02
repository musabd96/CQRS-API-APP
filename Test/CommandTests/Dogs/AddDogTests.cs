using Application.Commands.Dogs;
using Application.Dtos;
using Infrastructure.Database;

namespace Test.CommandTest.Dogs
{
    [TestFixture]
    public class AddDogTests
    {
        private AddDogCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _mockDatabase = new MockDatabase();
            _handler = new AddDogCommandHandler(_mockDatabase);
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
