using Application.Queries.Dogs;
using Application.Queries.Dogs.GetById;
using Infrastructure.Database;

namespace Test.QueryTests.Dogs
{
    [TestFixture]
    public class GetDogByIdTests
    {
        private GetDogByIdQueryHandler _handler;
        private MockDatabase _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new GetDogByIdQueryHandler(_originalDatabase);
        }

        [Test]
        public async Task Handle_ValidId_ReturnsCorrectDog()
        {
            // Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345678");

            var query = new GetDogByIdQuery(dogId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.That(result.Id, Is.EqualTo(dogId));
        }

        [Test]
        public async Task Handle_InvalidId_ReturnsNull()
        {
            // Arrange
            var invalidDogId = Guid.NewGuid();

            var query = new GetDogByIdQuery(invalidDogId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
