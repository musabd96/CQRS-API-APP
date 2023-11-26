using Application.Commands.Cats.DeleteCat;
using Application.Commands.Dogs.DeleteDog;
using Application.Queries.Dogs.GetById;
using Infrastructure.Database;

namespace Test.CommandTests.Cat
{
    [TestFixture]
    public class DeleteCatByIdTests
    {
        private DeleteCatByIdCommandHandler _handler;
        private MockDatabase _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new DeleteCatByIdCommandHandler(_originalDatabase);
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
