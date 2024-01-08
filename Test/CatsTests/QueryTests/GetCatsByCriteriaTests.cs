using Moq;
using Domain.Models;
using Infrastructure.Repositories.Cats;
using Application.Queries.Cats.GetbyBreed;

namespace Test.Cats.QueryTests
{
    [TestFixture]
    public class GetCatsByCriteriaTests
    {
        private GetAllCatsByCriteriaQueryHandler _handler;
        private Mock<ICatRepository> _catRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new GetAllCatsByCriteriaQueryHandler(_catRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            _catRepositoryMock.Setup(repo => repo.GetAllCatsByCriteria(
                    It.IsAny<string>(),
                    It.IsAny<int>(),
                    It.IsAny<CancellationToken>()))
                             .ReturnsAsync((string breed, int weight, CancellationToken cancellationToken) =>
                             {
                                 return cats.Where(c => (string.IsNullOrEmpty(breed) || c.Breed == breed) &&
                                           (weight == 0 || c.Weight >= weight)).ToList();
                             });
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllDogsByBreed()
        {
            // Arrange
            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(),Name = "Buddy", Breed = "Siamese", Weight = 9 },
                new Cat { Id = Guid.NewGuid(),Name = "Joe", Breed = "Siamese", Weight = 9  }
            };
            SetupMockDbContext(catsList);
            var breed = "Siamese";
            var weight = 9;

            //Act
            var result = await _handler.Handle(new GetAllCatsByCriteriaQuery(breed, weight), CancellationToken.None);

            //Assert
            Assert.That(result, Is.EqualTo(catsList));
        }
        [Test]
        public async Task Handle_InValid_ReturnsEmptyList()
        {
            // Arrange
            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(),Name = "Buddy", Breed = "Siamese", Weight = 9  },
                new Cat { Id = Guid.NewGuid(),Name = "Joe", Breed = "Siamese", Weight = 9  }
            };
            SetupMockDbContext(catsList);
            var invalidBreed = "InvalidBreed";
            var invalidWeight = 10;

            //Act
            var result = await _handler.Handle(new GetAllCatsByCriteriaQuery(invalidBreed, invalidWeight), CancellationToken.None);

            //Assert
            Assert.That(result, Is.Empty);
        }
    }
}
