using Domain.Models;
using Infrastructure.Database;
using Application.Queries.Birds.GetAll;
using Moq;
using Microsoft.EntityFrameworkCore;

namespace Test.QueryTests.Birds
{
    [TestFixture]
    public class GetAllBirdsTests
    {
        private GetAllBirdsQueryHandler _handler;
        private GetAllBirdsQuery _request;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void Setup()
        {
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new GetAllBirdsQueryHandler(_dbContextMock.Object);
            _request = new GetAllBirdsQuery();
        }

        protected void SetupMockDbContext(List<Bird> birds)
        {
            var mockDbSet = new Mock<DbSet<Bird>>();
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.Provider).Returns(birds.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.Expression).Returns(birds.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.ElementType).Returns(birds.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.GetEnumerator()).Returns(birds.GetEnumerator());

            _dbContextMock.Setup(b => b.Birds).Returns(mockDbSet.Object);
        }

        [Test]
        public async Task Handle_ValidRequest_ReturnsListOfBirds()
        {
            // Arrange
            var birdsList = new List<Bird>
            {
                new Bird { Id = Guid.NewGuid(), Name = "Sparrow" },
                new Bird { Id = Guid.NewGuid(), Name = "Robin" }
            };

            SetupMockDbContext(birdsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(birdsList.Count));
        }

        [Test]
        public async Task Handle_EmptyList_ReturnsEmptyList()
        {
            // Arrange
            var emptyBirdsList = new List<Bird>();
            SetupMockDbContext(emptyBirdsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsEmpty(result);
        }


    }
}
