using Application.Queries.Cats.GetById;
using Domain.Models;
using Infrastructure.Repositories.Cats;
using Moq;

namespace Test.Cats.QueryTests
{
    [TestFixture]
    public class GetCatByIdTests
    {
        private GetCatByIdQueryHandler _handler;
        private Mock<ICatRepository> _catRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new GetCatByIdQueryHandler(_catRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            _catRepositoryMock.Setup(repo => repo.GetCatById(It.IsAny<Guid>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((Guid catId, CancellationToken cancellationToken) => cats.FirstOrDefault(c => c.Id == catId));
        }

        [Test]
        public async Task Handle_ValidId_ReturnsCorrectCat()
        {
            // Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345678");
            var cat = new List<Cat>
            {
                new Cat { Id = catId }
            };

            SetupMockDbContext(cat);

            var query = new GetCatByIdQuery(catId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.That(result.Id, Is.EqualTo(catId));
        }

        [Test]
        public async Task Handle_InvalidId_ReturnsNull()
        {
            // Arrange
            var invalidCatId = Guid.NewGuid();

            // Empty list to simulate no matching bird
            SetupMockDbContext(new List<Cat>());

            var query = new GetCatByIdQuery(invalidCatId);

            // Act
            var result = await _handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
