using Domain.Models;
using Infrastructure.Database;
using Application.Queries.Birds.GetAll;

namespace Test.QueryTests.Birds
{
    [TestFixture]
    public class GetAllBirdsTests
    {
        private GetAllBirdsQueryHandler _handler;
        private MockDatabase? _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new GetAllBirdsQueryHandler(_mockDatabase!);
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllBirds()
        {
            // Arrange
            List<Bird> expectedBirds = _originalDatabase.Birds;

            // Act
            List<Bird> result = await _handler.Handle(new GetAllBirdsQuery(), CancellationToken.None);

            // Assert
            CollectionAssert.AreEqual(expectedBirds, result);
        }

        [Test]
        public async Task Handle_InvalidDatabase_ReturnsNullOrEmptyList()
        {
            // Arrange
            // Set up the database to simulate an invalid scenario (e.g., set it to null or throw an exception)
            _mockDatabase = null;
            _handler = new GetAllBirdsQueryHandler(_mockDatabase!);

            // Act
            List<Bird> result = await _handler.Handle(new GetAllBirdsQuery(), CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
