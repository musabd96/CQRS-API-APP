using Application.Queries.Cats.GetById;
using Infrastructure.Database;

namespace Test.QueryTests.Cats
{
    [TestFixture]
    public class GetCatByIdTests
    {
        private GetCatByIdQueryHandler _handler;
        private MockDatabase _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new GetCatByIdQueryHandler(_originalDatabase);
        }

        [Test]
        public async Task Handle_ValidId_ReturnsCorrectCat()
        {
            // Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345678");

            var query = new GetCatByIdQuery(catId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.That(result.Id, Is.EqualTo(catId));
        }

        [Test]
        public async Task Handle_InvalidId_ReturnsNull()
        {
            // Arrange
            var invalidCatId = Guid.NewGuid();

            var query = new GetCatByIdQuery(invalidCatId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
