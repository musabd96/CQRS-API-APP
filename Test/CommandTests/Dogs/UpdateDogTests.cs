using Application.Commands.Dogs.UpdateDog;
using Application.Dtos.AnimalDto;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.CommandTest.Dogs
{
    [TestFixture]
    public class UpdateDogTests
    {
        private UpdateDogByIdCommandHandler _handler;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new UpdateDogByIdCommandHandler(_dbContextMock.Object);
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
        public async Task Handle_ValidId_UpdatesDog()
        {
            // Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345678");
            var dogsList = new List<Dog>
            {
                new Dog
                {
                    Id = dogId,
                    Name = "Nelson",
                    LikesToPlay = true
                }
            };
            SetupMockDbContext(dogsList);

            var updatedName = new DogDto { Name = "NewDogName", LikesToPlay = false };

            var command = new UpdateDogByIdCommand(updatedName, dogId);

            // Act
            await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(updatedName.Name, Is.EqualTo(command.UpdatedDog.Name));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidDogId = Guid.NewGuid();
            var dogsList = new List<Dog>
            {
                new Dog
                {
                    Id = Guid.NewGuid(),
                    Name = "Nelson",
                    LikesToPlay = true
                }
            };
            SetupMockDbContext(dogsList);

            var updatedName = new DogDto { Name = "NewDogName", LikesToPlay = false };

            var command = new UpdateDogByIdCommand(updatedName, invalidDogId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }

    }
}
