using Application.Commands.Dogs.UpdateDog;
using Application.Dtos.AnimalDto;
using Domain.Models;
using Infrastructure.Repositories.Dogs;
using Moq;

namespace Test.Dogs.CommandTests
{
    [TestFixture]
    public class UpdateDogTests
    {
        private UpdateDogByIdCommandHandler _handler;
        private Mock<IDogRepository> _dogRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new UpdateDogByIdCommandHandler(_dogRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Dog> dogs)
        {
            _dogRepositoryMock.Setup(repo => repo.UpdateDog(
                    It.IsAny<Guid>(),
                    It.IsAny<string>(),  // Assuming 'Name' is a property of Dog
                    It.IsAny<bool>(),    // Assuming 'LikesToPlay' is a property of Dog
                    It.IsAny<string>(),    // Assuming 'Breed' is a property of Dog
                    It.IsAny<int>(),    // Assuming 'Weight' is a property of Dog
                    It.IsAny<string>(),    // Assuming 'OwnerDogUserName' is a property of Dog
                    It.IsAny<CancellationToken>()
                ))
                .Returns((Guid dogId, string updatedDogName,
                          bool updatedDogLikesToPlay, string updatedDogBreed,
                          int weight, string ownerDogUserName, CancellationToken cancellationToken) =>
                {
                    var existingDog = dogs.FirstOrDefault(d => d.Id == dogId);

                    if (existingDog != null)
                    {
                        existingDog.Name = updatedDogName;
                        existingDog.LikesToPlay = updatedDogLikesToPlay;
                        existingDog.Breed = updatedDogBreed;
                        existingDog.Weight = weight;
                        existingDog.OwnerUserName = ownerDogUserName;
                    }
                    return Task.FromResult(existingDog)!;
                });
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
                    LikesToPlay = true,
                    Breed = "Labrador",
                    Weight = 9,
                    OwnerUserName = "testOwner"
                }
            };
            SetupMockDbContext(dogsList);

            var updatedName = new DogDto
            {
                Name = "NewDogName",
                LikesToPlay = false,
                Breed = "NewDogBreed",
                Weight = 9,
                OwnerUserName = "testOwner"
            };

            var command = new UpdateDogByIdCommand(dogId, updatedName);

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
                    LikesToPlay = true,
                    Breed = "Labrador",
                    Weight = 9,
                    OwnerUserName = "testOwner"
                }
            };
            SetupMockDbContext(dogsList);

            var updatedName = new DogDto
            {
                Name = "NewDogName",
                LikesToPlay = false,
                Breed = "NewDogBreed",
                Weight = 10,
                OwnerUserName = "testOwner"
            };

            var command = new UpdateDogByIdCommand(invalidDogId, updatedName);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }

    }
}
