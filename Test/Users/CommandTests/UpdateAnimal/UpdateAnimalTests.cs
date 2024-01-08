using Application.Commands.Users.UpdateAnimal;
using Application.Dtos.Animals;
using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Repositories.Users;
using Moq;

[TestFixture]
public class UpdateAnimalTests
{
    private UpdateAnimalsCommandHandler _handler;
    private Mock<IUserRepository> _userRepository;

    [SetUp]
    public void Setup()
    {
        _userRepository = new Mock<IUserRepository>();
        _handler = new UpdateAnimalsCommandHandler(_userRepository.Object);
    }

    private void SetupMockUserRepository(List<AnimalModel> updatedAnimals)
    {
        _userRepository.Setup(repo => repo.UpdateAnimal(
                It.IsAny<string>(),
                It.IsAny<Guid>(),
                It.IsAny<string>(),
                It.IsAny<bool>(),
                It.IsAny<string>(),
                It.IsAny<int>(),
                It.IsAny<string>(),
                It.IsAny<CancellationToken>()))!
            .ReturnsAsync((string userName, Guid id, string newName, bool likesToPlay,
                            string breed, int weight, string color, CancellationToken cancellationToken) =>
            {
                var existingAnimal = updatedAnimals.FirstOrDefault(a => a.Id == id);
                if (existingAnimal != null)
                {
                    existingAnimal.Name = newName;
                    existingAnimal.LikesToPlay = likesToPlay;
                    existingAnimal.Breed = breed;
                    existingAnimal.Weight = weight;
                    existingAnimal.Color = color;
                }
                return existingAnimal;
            });
    }


    [Test]
    public async Task Handle_ValidCommand_UpdateAnimal()
    {
        // Arrange
        var username = "testuser";

        var animalId = new Guid("12345678-1234-5678-1234-567812345678");
        var updatedAnimals = new List<AnimalModel>
        {
            new Bird
            {
                Id = animalId,
                Name = "Buddy",
                LikesToPlay = true,
                Color = "Golden"
            }
        };

        SetupMockUserRepository(updatedAnimals);

        var command = new UpdateAnimalsCommand(
            animalId,
            new AnimalDto
            {
                Name = "Buddy",
                LikesToPlay = true,
                Color = "Golden"
            },
            username
        );

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        Assert.NotNull(result);
        Assert.That(result.Id, Is.EqualTo(command.Id));
    }

    [Test]
    public async Task Handle_InValidAnimalId_ReturnsNull()
    {
        // Arrange
        var username = "testuser";
        var invalidAnimalId = Guid.NewGuid();
        var updatedAnimals = new List<AnimalModel>
        {
            new Bird
            {
                Id = Guid.NewGuid(),
                Name = "Buddy",
                LikesToPlay = true,
                Breed = "Golden Retriever",
                Weight = 30,
                Color = "Golden"
            }
        };

        SetupMockUserRepository(updatedAnimals);

        var command = new UpdateAnimalsCommand(
            invalidAnimalId,
            new AnimalDto
            {
                Name = "Buddy",
                LikesToPlay = true,
                Breed = "Golden Retriever",
                Weight = 30,
                Color = "Golden"
            },
            username
        );

        // Act
        var result = await _handler.Handle(command, CancellationToken.None);

        // Assert
        Assert.Null(result);
    }
}
