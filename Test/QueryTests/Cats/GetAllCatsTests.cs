using Application.Queries.Cats.GettAll;
using Domain.Models;
using Infrastructure.Database;
using Application.Queries.Cats;
using Moq;
using Microsoft.EntityFrameworkCore;

namespace Test.QueryTests.Cats
{
    [TestFixture]
    public class GetAllCatsTests
    {
        private GetAllCatsQueryhandler _handler;
        private GetAllCatsQuery _request;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new GetAllCatsQueryhandler(_dbContextMock.Object);
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            var mockDbSet = new Mock<DbSet<Cat>>();
            mockDbSet.As<IQueryable<Cat>>().Setup(m => m.Provider).Returns(cats.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Cat>>().Setup(m => m.Expression).Returns(cats.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Cat>>().Setup(m => m.ElementType).Returns(cats.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Cat>>().Setup(m => m.GetEnumerator()).Returns(cats.GetEnumerator());

            _dbContextMock.Setup(c => c.Cats).Returns(mockDbSet.Object);
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllCats()
        {
            // Arrange
            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(), Name = "Sparrow" },
                new Cat { Id = Guid.NewGuid(), Name = "Robin" }
            };

            SetupMockDbContext(catsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(catsList.Count));
        }

        [Test]
        public async Task Handle_InvalidDatabase_ReturnsNullOrEmptyList()
        {
            // Arrange
            var emptyCatsList = new List<Cat>();
            SetupMockDbContext(emptyCatsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsEmpty(result);
        }
    }
}
