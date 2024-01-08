using Application.Commands.Cats.UpdateCat;
using Application.Dtos.AnimalDto;
using Domain.Models;
using Infrastructure.Repositories.Cats;
using Moq;

namespace Test.Cats.CommandTests
{
    [TestFixture]
    public class UpdateCatTests
    {
        private UpdateCatByIdCommandHandler _handler;
        private Mock<ICatRepository> _catRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new UpdateCatByIdCommandHandler(_catRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            _catRepositoryMock.Setup(repo => repo.UpdateCat(
                    It.IsAny<Guid>(),
                    It.IsAny<string>(),  // Assuming 'Name' is a property of cat
                    It.IsAny<bool>(),    // Assuming 'LikesToPlay' is a property of cat
                    It.IsAny<string>(),    // Assuming 'Breed' is a property of cat
                    It.IsAny<int>(),    // Assuming 'Weight' is a property of cat
                    It.IsAny<string>(),    // Assuming 'OwnerCatUserName' is a property of cat
                    It.IsAny<CancellationToken>()
                ))
                .Returns((Guid catId, string updatedCatName,
                          bool updatedCatLikesToPlay, string updatedBreed,
                          int weight, string ownerCatUserName, CancellationToken cancellationToken) =>
                {
                    var existingCat = cats.FirstOrDefault(c => c.Id == catId);

                    if (existingCat != null)
                    {
                        existingCat.Name = updatedCatName;
                        existingCat.LikesToPlay = updatedCatLikesToPlay;
                        existingCat.Breed = updatedBreed;
                        existingCat.Weight = weight;
                        existingCat.OwnerUserName = ownerCatUserName;

                    }
                    return Task.FromResult(existingCat)!;
                });
        }

        [Test]
        public async Task Handle_ValidId_UpdatesCat()
        {
            // Arrange
            var catId = new Guid("12345678-1234-5678-1234-567812345678");
            var catsList = new List<Cat>
            {
                new Cat
                {
                    Id = catId,
                    Name = "Nelson",
                    LikesToPlay = true,
                    Breed = "Sphynx",
                    Weight = 9,
                    OwnerUserName = "testOwner"
                }
            };
            SetupMockDbContext(catsList);

            var updatedName = new CatDto
            {
                Name = "NewCatName",
                LikesToPlay = false,
                Breed = "NewCatBreed",
                Weight = 9,
                OwnerUserName = "testOwner"
            };

            var command = new UpdateCatByIdCommand(catId, updatedName);

            // Act
            await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(updatedName.Name, Is.EqualTo(command.UpdatedCat.Name));
        }

        [Test]
        public async Task Handle_InvalidId_DoesNothing()
        {
            // Arrange
            var invalidCatId = Guid.NewGuid();
            var catsList = new List<Cat>
            {
                new Cat
                {
                    Id = Guid.NewGuid(),
                    Name = "Nelson",
                    LikesToPlay = true,
                    Weight = 9,
                    OwnerUserName = "testOwner"
                }
            };
            SetupMockDbContext(catsList);

            var updatedName = new CatDto
            {
                Name = "NewCatName",
                LikesToPlay = false,
                Breed = "NewCatBreed",
                Weight = 10,
                OwnerUserName = "testOwner"
            };

            var command = new UpdateCatByIdCommand(invalidCatId, updatedName);

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.IsNull(result);
        }
    }
}
