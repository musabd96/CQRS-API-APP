using Application.Commands.Dogs;
using Application.Dtos.AnimalDto;
using Application.Validators.Dog;
using Domain.Models;
using Infrastructure.Repositories.Dogs;
using Moq;

namespace Test.Dogs.CommandTests
{
    [TestFixture]
    public class AddDogTests
    {
        private AddDogCommandHandler _handler;
        private Mock<IDogRepository> _dogRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new AddDogCommandHandler(_dogRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Dog> dogs)
        {
            _dogRepositoryMock.Setup(repo => repo.AddDog(It.IsAny<Dog>(), It.IsAny<CancellationToken>()))
                .Callback((Dog dog, CancellationToken cancellationToken) => dogs.Add(dog))
                .Returns((Dog dog, CancellationToken cancellationToken) => Task.FromResult(dog));
        }

        [Test]
        public async Task Handle_ValidCommand_AddNewDog()
        {
            // Arrange
            var dogs = new List<Dog>();
            SetupMockDbContext(dogs);

            var command = new AddDogCommand(new DogDto { Name = "NewDog" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(result.Name, Is.EqualTo("NewDog"));
        }

        [Test]
        public async Task Handle_InValidCommand_EmptyDogName()
        {
            // Arrange
            var validator = new DogValidator();
            var dogName = new DogDto { Name = "" };

            // Act
            var result = await Task.FromResult(validator.Validate(dogName));

            // Assert
            Assert.That(result.Errors.Single().ErrorMessage, Is.EqualTo("Dog Name can not be empty"));
        }
    }
}
