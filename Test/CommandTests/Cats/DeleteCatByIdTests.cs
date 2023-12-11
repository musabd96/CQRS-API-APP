using Application.Commands.Birds.DeleteBird;
using Application.Commands.Cats;
using Application.Commands.Cats.DeleteCat;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.CommandTests.Cats
{
    [TestFixture]
    public class DeleteCatByIdTests
    {
        private DeleteCatByIdCommandHandler _handler;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new DeleteCatByIdCommandHandler(_dbContextMock.Object);
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
        public async Task Handle_ValidId_DeletesCat()
        {
            // Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345678");
            var cat = new List<Cat>
            {
                new Cat
                {
                    Id = catId
                }
            };
            SetupMockDbContext(cat);

            var command = new DeleteCatByIdCommand(catId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(catId));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidCatId = Guid.NewGuid();
            var cat = new List<Cat>();
            SetupMockDbContext(cat);

            var command = new DeleteCatByIdCommand(invalidCatId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
