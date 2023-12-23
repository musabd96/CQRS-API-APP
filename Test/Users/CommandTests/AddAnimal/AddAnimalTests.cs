using Application.Commands.Users.AddAnimal;
using Application.Dtos.Animals;
using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Repositories.Users;
using Moq;

namespace Test.Users.CommandTests.AddAnimal
{
    [TestFixture]
    public class AddAnimalTests
    {
        private AddAnimalsCommandHandler _handler;
        private Mock<IUserRepository> _userRepository;

        [SetUp]
        public void Setup()
        {
            _userRepository = new Mock<IUserRepository>();
            _handler = new AddAnimalsCommandHandler(_userRepository.Object);
        }

        private void SetupMockUserRepository(List<AnimalModel> newAnimal)
        {
            _userRepository.Setup(repo => repo.AddAnimal(
                It.IsAny<string>(),
                It.IsAny<AnimalModel>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(newAnimal);
        }



        [Test]
        public async Task Handle_ValidCommand_AddAnimal()
        {
            // Arrange
            var username = "testuser";
            var newAnimal = new List<AnimalModel>();
            SetupMockUserRepository(newAnimal);

            var command = new AddAnimalsCommand(
                username,
                new AnimalDto
                {
                    Name = "Buddy",
                    TypeOfAnimal = "Dog",
                    LikesToPlay = true,
                    Breed = "Golden Retriever",
                    Weight = 30,
                    Color = "Golden"
                });


            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.That(result.Count, Is.EqualTo(1));

        }

        [Test]
        public async Task Handle_InValidCommand_EmptyDogName()
        {
            // Arrenge


            //Act

            //Assert
        }

    }
}
