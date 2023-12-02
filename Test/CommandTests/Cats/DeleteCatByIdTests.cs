using Application.Commands.Cats.DeleteCat;
using Infrastructure.Database;

namespace Test.CommandTests.Cat
{
    [TestFixture]
    public class DeleteCatByIdTests
    {
        private DeleteCatByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _mockDatabase = new MockDatabase();
            _handler = new DeleteCatByIdCommandHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidId_DeletesCat()
        {
            // Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345670");

            var command = new DeleteCatByIdCommand(catId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(catId));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidCatId = Guid.NewGuid();

            var command = new DeleteCatByIdCommand(invalidCatId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
