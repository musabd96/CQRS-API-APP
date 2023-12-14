using Application.Commands.Cats.DeleteCat;
using Domain.Models;
using Infrastructure.Repositories.Cats;
using Moq;

namespace Test.Cats.CommandTests
{
    [TestFixture]
    public class DeleteCatByIdTests
    {
        private DeleteCatByIdCommandHandler _handler;
        private Mock<ICatRepository> _catRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new DeleteCatByIdCommandHandler(_catRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            _catRepositoryMock.Setup(repo => repo.DeleteCat(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                .Returns((Guid catId, CancellationToken cancellationToken) =>
                {
                    var birdToDelete = cats.FirstOrDefault(bird => bird.Id == catId);

                    return Task.FromResult<Cat>(null!);
                });
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
            Assert.Null(result);
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
