using Application.Commands.Cats.UpdateCat;
using Application.Dtos;
using Infrastructure.Database;

namespace Test.CommandTests.Cat
{
    [TestFixture]
    public class UpdateCatTests
    {
        private UpdateCatByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _mockDatabase = new MockDatabase();
            _handler = new UpdateCatByIdCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidId_UpdatesCat()
        {
            // Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345678");
            var updatedName = new CatDto { Name = "NewCatName", LikesToPlay = false };

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
