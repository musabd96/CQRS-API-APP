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

        private void SetupMockDbSet(List<Bird> birdsList)
        {
            var mockDbSet = new Mock<DbSet<Bird>>();
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.Provider).Returns(birdsList.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.Expression).Returns(birdsList.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.ElementType).Returns(birdsList.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Bird>>().Setup(m => m.GetEnumerator()).Returns(() => birdsList.AsQueryable().GetEnumerator());
            mockDbSet.As<IAsyncEnumerable<Bird>>().Setup(m => m.GetAsyncEnumerator(It.IsAny<CancellationToken>()))
                .Returns(new TestAsyncEnumerator<Bird>(birdsList.GetEnumerator()));

            _dbContextMock.Setup(x => x.Birds).Returns(mockDbSet.Object);
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

            SetupMockDbSet(birdsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(birdsList.Count));
        }

        [Test]
        public void Handle_EmptyList_ThrowsInvalidOperationException()
        {
            // Arrange
            var emptyBirdsList = new List<Bird>();
            SetupMockDbSet(emptyBirdsList);

            // Act
            var result = _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.ThrowsAsync<InvalidOperationException>(() => result);
        }

    }

    // TestAsyncEnumerator is a simple implementation of IAsyncEnumerator<T> for testing.
    internal class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _enumerator;

        public TestAsyncEnumerator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator ?? throw new ArgumentNullException(nameof(enumerator));
        }

        public ValueTask<bool> MoveNextAsync()
        {
            return new ValueTask<bool>(_enumerator.MoveNext());
        }

        public T Current => _enumerator.Current;

        public ValueTask DisposeAsync()
        {
            _enumerator.Dispose();
            return new ValueTask();
        }
    }
}
