using Domain.Models;
using Application.Queries.Cats;
using Moq;
using Infrastructure.Repositories.Cats;
using Application.Queries.Cats.GettAll;

namespace Test.Cats.QueryTests
{
    [TestFixture]
    public class GetAllCatsTests
    {
        private GetAllCatsQueryhandler _handler;
        private GetAllCatsQuery _request;
        private Mock<ICatRepository> _catRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new GetAllCatsQueryhandler(_catRepositoryMock.Object);
            _request = new GetAllCatsQuery();
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            _catRepositoryMock.Setup(repo => repo.GetAllCats(It.IsAny<CancellationToken>()))
                .ReturnsAsync(cats);
        }

        [Test]
        public async Task Handle_Valid_ReturnsAllCats()
        {
            // Arrange
            var catsList = new List<Cat>
            {
                new Cat { Id = Guid.NewGuid(), Name = "Sparrow" },
                new Cat { Id = Guid.NewGuid(), Name = "Robin" }
            };

            SetupMockDbContext(catsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(catsList.Count));
        }

        [Test]
        public async Task Handle_InvalidDatabase_ReturnsNullOrEmptyList()
        {
            // Arrange
            var emptyCatsList = new List<Cat>();
            SetupMockDbContext(emptyCatsList);

            // Act
            var result = await _handler.Handle(_request, CancellationToken.None);

            // Assert
            Assert.IsEmpty(result);
        }
    }
}
