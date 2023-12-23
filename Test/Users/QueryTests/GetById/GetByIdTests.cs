using Moq;
using Infrastructure.Repositories.Users;
using Application.Queries.Users.GetById;
using Domain.Models.Animal;
using Domain.Models;

namespace Test.Users.QueryTests.GetById
{
    [TestFixture]
    public class GetByIdTests
    {
        private GetAnimalByIdQueryHandler _handler;
        private Mock<IUserRepository> _userRepository;

        [SetUp]
        public void Setup()
        {
            _userRepository = new Mock<IUserRepository>();
            _handler = new GetAnimalByIdQueryHandler(_userRepository.Object);
        }

        private void SetupMockUserRepository(List<AnimalModel> getAnimal)
        {
            _userRepository.Setup(repo => repo.GetAnimalById(
                It.IsAny<Guid>(),
                It.IsAny<string>(),
                It.IsAny<CancellationToken>()))!
                .ReturnsAsync((Guid id, string username, CancellationToken cancellationToken) =>
                {
                    var animalToGet = getAnimal.FirstOrDefault(a => a.Id == id);
                    return animalToGet;
                });
        }

        [Test]
        public async Task Handle_Valid_ReturnsAnimal()
        {
            // Arrange
            var username = "testuser";

            var animalId = new Guid("12345678-1234-5678-1234-567812345678");
            var animal = new List<AnimalModel>
            {
                new Bird
                {
                    Id = animalId,
                    Name = "Buddy",
                    LikesToPlay = true,
                    Color = "Golden"
                }
            };

            SetupMockUserRepository(animal);

            // Act
            var result = await _handler.Handle(new GetAnimalByIdQuery(animalId, username), CancellationToken.None);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(animalId));
        }

        [Test]
        public async Task Handle_InvalidAnimalId_ReturnNUll()
        {
            // Arrange
            var username = "testuser";

            var animalId = new Guid("12345678-1234-5678-1234-567812345678");
            var animal = new List<AnimalModel>
            {
                new Bird
                {
                    Id = animalId,
                    Name = "Buddy",
                    LikesToPlay = true,
                    Color = "Golden"
                }
            };

            SetupMockUserRepository(animal);
            var invalidAnimalId = Guid.NewGuid();

            // Act
            var result = await _handler.Handle(new GetAnimalByIdQuery(invalidAnimalId, username), CancellationToken.None);

            // Assert
            Assert.Null(result);
        }
    }
}
