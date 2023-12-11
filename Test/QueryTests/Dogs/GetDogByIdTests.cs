﻿using Application.Queries.Birds.GetById;
using Application.Queries.Dogs.GetById;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.QueryTests.Dogs
{
    [TestFixture]
    public class GetDogByIdTests
    {
        private GetDogByIdQueryHandler _handler;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void Setup()
        {
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new GetDogByIdQueryHandler(_dbContextMock.Object);
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
        public async Task Handle_ValidId_ReturnsCorrectDog()
        {
            // Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345678");
            var dog = new List<Dog>
            {
                new Dog { Id = dogId }
            };

            SetupMockDbContext(dog);

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

            // Empty list to simulate no matching bird
            SetupMockDbContext(new List<Dog>());

            var query = new GetDogByIdQuery(invalidDogId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
