using Moq;
using Domain.Models;
using Infrastructure.Repositories.Cats;
using Application.Queries.Cats.GetbyBreed;

namespace Test.DogsTests.QueryTests
{
    [TestFixture]
    public class GetCatByBreedTests
    {
        private GetAllCatsByBreedQueryHandler _handler;
        private Mock<ICatRepository> _catRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new GetAllCatsByBreedQueryHandler(_catRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            _catRepositoryMock.Setup(repo => repo.GetAllCatsByBreed(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                             .ReturnsAsync((string breed, CancellationToken cancellationToken) =>
                             {
                                 return cats.FindAll(c => c.Breed == breed);
                             });
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllDogsByBreed()
        {
            // Arrange
            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(),Name = "Buddy", Breed = "Siamese" },
                new Cat { Id = Guid.NewGuid(),Name = "Joe", Breed = "Siamese" }
            };
            SetupMockDbContext(catsList);
            var breed = "Siamese";

            //Act
            var result = await _handler.Handle(new GetAllCatsByBreedQuery(breed), CancellationToken.None);

            //Assert
            Assert.That(result, Is.EqualTo(catsList));
        }
        [Test]
        public async Task Handle_InValid_ReturnsEmptyList()
        {
            // Arrange
            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(),Name = "Buddy", Breed = "Siamese" },
                new Cat { Id = Guid.NewGuid(),Name = "Joe", Breed = "Siamese" }
            };
            SetupMockDbContext(catsList);
            var InvalidBreed = "InvalidBreed";

            //Act
            var result = await _handler.Handle(new GetAllCatsByBreedQuery(InvalidBreed), CancellationToken.None);

            //Assert
            Assert.That(result, Is.Empty);
        }
    }
}
