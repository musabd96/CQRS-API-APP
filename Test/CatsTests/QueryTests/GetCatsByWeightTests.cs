using Application.Queries.Cats.GetByWieght;
using Domain.Models;
using Infrastructure.Repositories.Cats;
using Moq;

namespace Test.CatsTests.QueryTests
{
    [TestFixture]
    public class GetCatsByWeightTests
    {
        private GetAllCatsByWeightQueryHandler _handler;
        private Mock<ICatRepository> _catRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new GetAllCatsByWeightQueryHandler(_catRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            _catRepositoryMock.Setup(repo => repo.GetAllDogsByWeight(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                             .ReturnsAsync((int weight, CancellationToken cancellationToken) =>
                             {
                                 return cats.FindAll(c => c.Weight == weight);
                             });
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllDogsByWeight()
        {
            // Arrange
            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(),Name = "Rocky", Weight = 9 },
                new Cat { Id = Guid.NewGuid(),Name = "Charlie", Weight = 9 }
            };
            SetupMockDbContext(catsList);
            int weight = 9;

            //Act
            var result = await _handler.Handle(new GetAllCatsByWeightQuery(weight), CancellationToken.None);

            //Assert
            Assert.That(result, Is.EqualTo(catsList));
        }
        [Test]
        public async Task Handle_InValid_ReturnsEmptyList()
        {
            // Arrange
            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(),Name = "Rocky", Weight = 9 },
                new Cat { Id = Guid.NewGuid(),Name = "Charlie", Weight = 9 }
            };
            SetupMockDbContext(catsList);
            int InvalidWeight = 10;

            //Act
            var result = await _handler.Handle(new GetAllCatsByWeightQuery(InvalidWeight), CancellationToken.None);

            //Assert
            Assert.That(result, Is.Empty);
        }
    }
}
