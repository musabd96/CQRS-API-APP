using Application.Commands.Cats;
using Application.Dtos;
using Infrastructure.Database;

namespace Test.CommandTests.Cat
{
    [TestFixture]
    public class AddCatTests
    {
        private AddCatCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _mockDatabase = new MockDatabase();
            _handler = new AddCatCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidCommand_AddNewCat()
        {
            // Arrange
            var command = new AddCatCommand(new CatDto { Name = "NewCat" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNotNull(_mockDatabase.Cats.FirstOrDefault(cat => cat.Name == "NewCat"));
            Assert.That(_mockDatabase.Cats.FirstOrDefault(cat => cat.Name == "NewCat").Name, Is.EqualTo("NewCat"));
        }

        [Test]
        public async Task Handle_InValidCommand_EmptyCatName()
        {
            // Arrange
            var command = new AddCatCommand(new CatDto { Name = "" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }



    }
}
