using Application.Queries.Birds.GetById;
using Infrastructure.Database;

namespace Test.QueryTests.Birds
{
    [TestFixture]
    public class GetBirdByIdTests
    {
        private GetBirdByIdQueryHandler _handler;
        private MockDatabase _mockDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _mockDatabase = new MockDatabase();
            _handler = new GetBirdByIdQueryHandler(_mockDatabase);
        }

        [Test]
        public async Task Handle_ValidId_ReturnsCorrectBird()
        {
            // Arrange
            var birdId = new Guid("12345678-1234-5678-1234-567812345678");

            var query = new GetBirdByIdQuery(birdId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.That(result.Id, Is.EqualTo(birdId));
        }

        [Test]
        public async Task Handle_InvalidId_ReturnsNull()
        {
            // Arrange
            var invalidBirdId = Guid.NewGuid();

            var query = new GetBirdByIdQuery(invalidBirdId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
