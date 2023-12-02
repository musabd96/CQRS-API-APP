using Application.Queries.Dogs.GetAll;
using Domain.Models;
using Infrastructure.Database;
using Application.Queries.Dogs;

namespace Test.QueryTests.Dogs
{
    [TestFixture]
    public class GetAllDogsTests
    {
        private GetAllDogsQueryHandler _handler;
        private MockDatabase? _mockDatabase;
        private MockDatabase _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _originalDatabase = new MockDatabase();
            _mockDatabase = _originalDatabase.Clone() as MockDatabase;
            _handler = new GetAllDogsQueryHandler(_mockDatabase!);
        }


        [Test]
        public async Task Handle_Valid_ReturnsAllDogs()
        {
            // Arrange
            List<Dog> expectedDogs = _originalDatabase.Dogs;

            // Act
            List<Dog> result = await _handler.Handle(new GetAllDogsQuery(), CancellationToken.None);

            // Assert
            CollectionAssert.AreEqual(expectedDogs, result);
        }

        [Test]
        public async Task Handle_InvalidDatabase_ReturnsNullOrEmptyList()
        {
            // Arrange
            // Set up the database to simulate an invalid scenario (e.g., set it to null or throw an exception)
            _mockDatabase = null;
            _handler = new GetAllDogsQueryHandler(_mockDatabase!);

            // Act
            List<Dog> result = await _handler.Handle(new GetAllDogsQuery(), CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
