using Application.Commands.Cats.UpdateCat;
using Application.Commands.Dogs.UpdateDog;
using Application.Dtos;
using Application.Queries.Dogs.GetById;
using Infrastructure.Database;

namespace Test.CommandTests.Cat
{
    [TestFixture]
    public class UpdateCatTests
    {
        private UpdateCatByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new UpdateCatByIdCommandHandler(_originalDatabase);
        }

        [Test]
        public async Task Handle_ValidId_UpdatesCat()
        {
            // Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345678");
            var updatedName = new CatDto { Name = "NewCatName" };

            var command = new UpdateCatByIdCommand(updatedName, catId);

            //Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Name, Is.EqualTo("NewCatName"));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidCatId = Guid.NewGuid();
            var invalidCatName = new CatDto { Name = "Name" };

            // Mock the database to simulate that no cat with the specified ID is found
            var mockDatabase = new MockDatabase();
            var handler = new UpdateCatByIdCommandHandler(mockDatabase);

            var command = new UpdateCatByIdCommand(invalidCatName, invalidCatId);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result, "The result should be null for an invalid cat ID.");
        }
    }
}
