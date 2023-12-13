using Application.Commands.Cats;
using Application.Dtos.AnimalDto;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Test.Cats.CommandTests
{
    [TestFixture]
    public class AddCatTests
    {
        private AddCatCommandHandler _handler;
        private Mock<AppDbContext> _dbContextMock;

        [SetUp]
        public void SetUp()
        {
            // Initialize the original database and create a clone for each test
            _dbContextMock = new Mock<AppDbContext>();
            _handler = new AddCatCommandHandler(_dbContextMock.Object);
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
        public async Task Handle_ValidCommand_AddNewCat()
        {
            // Arrange
            var cats = new List<Cat>();
            SetupMockDbContext(cats);

            var command = new AddCatCommand(new CatDto { Name = "NewCat" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(result.Name, Is.EqualTo("NewCat"));
        }

        [Test]
        public async Task Handle_InValidCommand_EmptyCatName()
        {
            // Arrange
            var command = new AddCatCommand(new CatDto { Name = "" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }



    }
}
