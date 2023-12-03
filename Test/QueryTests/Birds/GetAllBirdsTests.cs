using Domain.Models;
using Infrastructure.Database;
using Application.Queries.Birds.GetAll;
using Microsoft.EntityFrameworkCore;

namespace Test.QueryTests.Birds
{
    [TestFixture]
    public class GetAllBirdsTests
    {
        private GetAllBirdsQueryHandler _handler;
        private AppDbContext _dbContext;
        private AppDbContext _originalDatabase;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database for each test
            _originalDatabase = new AppDbContext();
            _dbContext = _originalDatabase.Clone();
            _handler = new GetAllBirdsQueryHandler(_dbContext);
        }


        [Test]
        public async Task Handle_Valid_ReturnsAllBirds()
        {
            // Arrange
            List<Bird> expectedBirds = await _originalDatabase.Birds.ToListAsync();
            List<Bird> _dbContext1 = await _dbContext.Birds.ToListAsync();

            // Act
            List<Bird> result = await _handler.Handle(new GetAllBirdsQuery(), CancellationToken.None);
            Console.WriteLine(_dbContext1.Count);
            // Assert
            CollectionAssert.AreEqual(expectedBirds, result);
        }

        [Test]
        public async Task Handle_InvalidDatabase_ReturnsNullOrEmptyList()
        {
            // Arrange
            // Set up the database to simulate an invalid scenario (e.g., set it to null or throw an exception)
            _dbContext = null!;
            _handler = new GetAllBirdsQueryHandler(null);

            // Act
            List<Bird> result = await _handler.Handle(new GetAllBirdsQuery(), CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
