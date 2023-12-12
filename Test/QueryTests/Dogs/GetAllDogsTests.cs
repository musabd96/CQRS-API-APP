using Application.Queries.Dogs.GetAll;
using Domain.Models;
using Infrastructure.Database;
using Application.Queries.Dogs;
using Moq;
using Microsoft.EntityFrameworkCore;

namespace Test.QueryTests.Dogs
{
    [TestFixture]
    public class GetAllDogsTests
    {
        private GetAllDogsQueryHandler _handler;
        private GetAllDogsQuery _request;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void Setup()
        {
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new GetAllDogsQueryHandler(_dbContextMock.Object);
            _request = new GetAllDogsQuery();
        }

        protected void SetupMockDbContext(List<Dog> dogs)
        {
            var mockDbSet = new Mock<DbSet<Dog>>();
            mockDbSet.As<IQueryable<Dog>>().Setup(m => m.Provider).Returns(dogs.AsQueryable().Provider);
            mockDbSet.As<IQueryable<Dog>>().Setup(m => m.Expression).Returns(dogs.AsQueryable().Expression);
            mockDbSet.As<IQueryable<Dog>>().Setup(m => m.ElementType).Returns(dogs.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<Dog>>().Setup(m => m.GetEnumerator()).Returns(dogs.GetEnumerator());

            _dbContextMock.Setup(d => d.Dogs).Returns(mockDbSet.Object);
        }


        [Test]
        public async Task Handle_Valid_ReturnsAllDogs()
        {
            // Arrange
            var dogsList = new List<Dog>
            {
                new Dog { Id = Guid.NewGuid(), Name = "Sparrow" },
                new Dog { Id = Guid.NewGuid(), Name = "Robin" }
            };

            SetupMockDbContext(dogsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(dogsList.Count));
        }

        [Test]
        public async Task Handle_InvalidDatabase_ReturnsNullOrEmptyList()
        {
            // Arrange
            var emptyDogsList = new List<Dog>();
            SetupMockDbContext(emptyDogsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsEmpty(result);
        }
    }
}
