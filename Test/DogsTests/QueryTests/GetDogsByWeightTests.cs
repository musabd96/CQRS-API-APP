using Application.Queries.Dogs.GetbyBreed;
using Domain.Models;
using Infrastructure.Repositories.Dogs;
using Moq;

namespace Test.DogsTests.QueryTests
{
    [TestFixture]
    public class GetDogsByWeightTests
    {
        private GetAllDogsByBreedQueryHandler _handler;
        private Mock<IDogRepository> _dogRepositoryMock;

        [SetUp]
        public void Setup()
        {
            _dogRepositoryMock = new Mock<IDogRepository>();
            _handler = new GetAllDogsByBreedQueryHandler(_dogRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Dog> dogs)
        {
            _dogRepositoryMock.Setup(repo => repo.GetAllDogsByWeight(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                             .ReturnsAsync((int weight, CancellationToken cancellationToken) =>
                             {
                                 return dogs.FindAll(d => d.Weight == weight);
                             });
        }
    }
}
