using Application.Commands.Birds.UpdateBird;
using Application.Commands.Cats.DeleteCat;
using Application.Commands.Cats.UpdateCat;
using Application.Dtos;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.CommandTests.Cats
{
    [TestFixture]
    public class UpdateCatTests
    {
        private UpdateCatByIdCommandHandler _handler;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new UpdateCatByIdCommandHandler(_dbContextMock.Object);
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
        public async Task Handle_ValidId_UpdatesCat()
        {
            // Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345678");
            var catsList = new List<Cat>
            {
                new Cat
                {
                    Id = catId,
                    Name = "Nelson",
                    LikesToPlay = true
                }
            };
            SetupMockDbContext(catsList);

            var updatedName = new CatDto { Name = "NewCatName", LikesToPlay = false };

            var command = new UpdateCatByIdCommand(updatedName, catId);

            // Act
            await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(updatedName.Name, Is.EqualTo(command.UpdatedCat.Name));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidCatId = Guid.NewGuid();
            var catsList = new List<Cat>
            {
                new Cat
                {
                    Id = Guid.NewGuid(),
                    Name = "Nelson",
                    LikesToPlay = true
                }
            };
            SetupMockDbContext(catsList);

            var updatedName = new CatDto { Name = "NewCatName", LikesToPlay = false };

            var command = new UpdateCatByIdCommand(updatedName, invalidCatId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
