using Application.Commands.Dogs.DeleteDog;
using Domain.Models;
using Infrastructure.Repositories.Dogs;
using Moq;

namespace Test.Dogs.CommandTests
{
    [TestFixture]
    public class DeleteDogByIdTest
    {
        private DeleteDogByIdCommandHandler _handler;
        private Mock<IDogRepository> _dogRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new DeleteDogByIdCommandHandler(_dogRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Dog> dogs)
        {
            _dogRepositoryMock.Setup(repo => repo.DeleteDog(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                .Returns((Guid dogId, CancellationToken cancellationToken) =>
                {
                    var dogToDelete = dogs.FirstOrDefault(d => d.Id == dogId);

                    return Task.FromResult<Dog>(null!);
                });
        }

        [Test]
        public async Task Handle_ValidId_DeletesDog()
        {
            // Arrange
            var dogId = new Guid("12345678-1234-5678-1234-567812345678");
            var dog = new List<Dog>
            {
                new Dog
                {
                    Id = dogId
                }
            };
            SetupMockDbContext(dog);

            var command = new DeleteDogByIdCommand(dogId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.Null(result);
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidDogId = Guid.NewGuid();
            var dog = new List<Dog>();
            SetupMockDbContext(dog);

            var command = new DeleteDogByIdCommand(invalidDogId);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}

