using Moq;
using Domain.Models.Animal;
using Infrastructure.Repositories.Users;
using Application.Queries.Users.GetAll;
using Domain.Models;

namespace Test.Users.QueryTests.GetAll
{
    [TestFixture]
    public class GetAllAnimalsTests
    {
        private GetAllAnimalsQueryHandler _handler;
        private Mock<IUserRepository> _userRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _userRepositoryMock = new Mock<IUserRepository>();
            _handler = new GetAllAnimalsQueryHandler(_userRepositoryMock.Object);
        }

        protected void SetupMockUserRepository(List<AnimalModel> animalModels)
        {
            _userRepositoryMock.Setup(repo => repo.GetAllAnimals(
                             It.IsAny<string>(),
                             It.IsAny<CancellationToken>()))
                             .ReturnsAsync(animalModels);
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllAnimals()
        {
            // Arrange
            var dogsList = new List<Dog>
            {
                new Dog { Id = Guid.NewGuid(), Name = "Sparrow", OwnerUserName = "Testning1!" },
                new Dog { Id = Guid.NewGuid(), Name = "Robin", OwnerUserName = "Testning1!" }
            };

            var birdsList = new List<Bird>
            {
                new Bird { Id = Guid.NewGuid(), Name = "Soe", OwnerUserName = "Testning1!" },
                new Bird { Id = Guid.NewGuid(), Name = "Blue", OwnerUserName = "Testning1!" }
            };

            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(), Name = "MJ", OwnerUserName = "Testning1!" },
                new Cat { Id = Guid.NewGuid(), Name = "DJ", OwnerUserName = "Testning1!" }
            };

            var animalModels = new List<AnimalModel>();

            animalModels.AddRange(dogsList.Select(dog => new AnimalModel
            { Id = dog.Id, Name = dog.Name, OwnerUserName = dog.OwnerUserName }));

            animalModels.AddRange(birdsList.Select(bird => new AnimalModel
            { Id = bird.Id, Name = bird.Name, OwnerUserName = bird.OwnerUserName }));

            animalModels.AddRange(catsList.Select(cat => new AnimalModel
            { Id = cat.Id, Name = cat.Name, OwnerUserName = cat.OwnerUserName }));


            SetupMockUserRepository(animalModels);
            var userName = "Testning1!";
            var query = new GetAllAnimalsQuery(userName);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result, Is.EqualTo(animalModels));
        }

        [Test]
        public async Task Handle_InvalidUsername_ReturnsEmptyList()
        {
            // Arrange
            var invalidUserName = "NonexistentUser";
            SetupMockUserRepository(new List<AnimalModel>());
            var query = new GetAllAnimalsQuery(invalidUserName);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsEmpty(result);
        }

    }
}
