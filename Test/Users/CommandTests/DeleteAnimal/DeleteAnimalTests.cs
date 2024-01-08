using Application.Commands.Users.DeketeAnimal;
using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Repositories.Users;
using Moq;

namespace Test.Users.CommandTests.DeleteAnimal
{
    [TestFixture]
    public class DeleteAnimalTests
    {
        private DeleteAnimalsCommandHandler _handler;
        private Mock<IUserRepository> _userRepository;

        [SetUp]
        public void Setup()
        {
            _userRepository = new Mock<IUserRepository>();
            _handler = new DeleteAnimalsCommandHandler(_userRepository.Object);
        }

        private void SetupMockUserRepository(List<AnimalModel> deleteAnimal)
        {
            _userRepository.Setup(repo => repo.DeleteAnimal(
                It.IsAny<Guid>(),
                It.IsAny<string>(),
                It.IsAny<CancellationToken>()))!
                .ReturnsAsync((Guid id, string username, CancellationToken cancellationToken) =>
                {
                    var animalToDelete = deleteAnimal.FirstOrDefault(a => a.Id == id);
                    return animalToDelete;
                });
        }

        [Test]
        public async Task Handle_ValidCommand_DeleteAnimal()
        {
            // Arrange
            var username = "testuser";

            var animalId = new Guid("12345678-1234-5678-1234-567812345678");
            var deleteAnimal = new List<AnimalModel>
            {
                new Bird
                {
                    Id = animalId,
                    Name = "Buddy",
                    LikesToPlay = true,
                    Color = "Golden"
                }
            };

            SetupMockUserRepository(deleteAnimal);

            var command = new DeleteAnimalsCommand(animalId, username);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Id, Is.EqualTo(command.Id));
        }

        [Test]
        public async Task Handle_InValidAnimalId_Retur()
        {
            // Arrange
            var username = "testuser";
            var animalId = new Guid("12345678-1234-5678-1234-567812345678");
            var deleteAnimal = new List<AnimalModel>
            {
                new Bird
                {
                    Id = animalId,
                    Name = "Buddy",
                    LikesToPlay = true,
                    Color = "Golden"
                }
            };
            var invalidAnimalId = Guid.NewGuid();

            var command = new DeleteAnimalsCommand(invalidAnimalId, username);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.Null(result);
        }
    }
}
