using Application.Commands.Cats;
using Application.Dtos;
using Application.Queries.Dogs.GetById;
using Infrastructure.Database;

namespace Test.CommandTests.Cat
{
    [TestFixture]
    public class AddCatTests
    {
        private AddCatCommandHandler _handler;
        private MockDatabase _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new AddCatCommandHandler(_originalDatabase);
        }

        [Test]
        public async Task Handle_ValidCommand_AddNewCat()
        {
            // Arrange
            var command = new AddCatCommand(new CatDto { Name = "NewCat" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            var newCatInDatabase = _mockDatabase.Cats.FirstOrDefault(cat => cat.Name == "NewCat");

            Assert.IsNotNull(newCatInDatabase);
            Assert.That(newCatInDatabase.Name, Is.EqualTo("NewCat"));
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
