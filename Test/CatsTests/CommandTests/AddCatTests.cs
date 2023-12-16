using Application.Commands.Cats;
using Application.Dtos.AnimalDto;
using Application.Validators.Cat;
using Domain.Models;
using Infrastructure.Repositories.Cats;
using Moq;

namespace Test.Cats.CommandTests
{
    [TestFixture]
    public class AddCatTests
    {
        private AddCatCommandHandler _handler;
        private Mock<ICatRepository> _catRepositoryMock;

        [SetUp]
        public void SetUp()
        {
            _catRepositoryMock = new Mock<ICatRepository>();
            _handler = new AddCatCommandHandler(_catRepositoryMock.Object);
        }

        protected void SetupMockDbContext(List<Cat> cats)
        {
            _catRepositoryMock.Setup(repo => repo.AddCat(It.IsAny<Cat>(), It.IsAny<CancellationToken>()))
                .Callback((Cat cat, CancellationToken cancellationToken) => cats.Add(cat))
                .Returns((Cat cat, CancellationToken cancellationToken) => Task.FromResult(cat));
        }

        [Test]
        public async Task Handle_ValidCommand_AddNewCat()
        {
            // Arrange
            var cats = new List<Cat>();
            SetupMockDbContext(cats);

            var command = new AddCatCommand(new CatDto { Name = "NewCat" });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(result.Name, Is.EqualTo("NewCat"));
        }

        [Test]
        public async Task Handle_InValidCommand_EmptyCatName()
        {
            // Arrange
            var validator = new CatValidator();
            var catName = new CatDto { Name = "" };

            // Act
            var result = await Task.FromResult(validator.Validate(catName));

            // Assert
            Assert.That(result.Errors.Single().ErrorMessage, Is.EqualTo("Cat Name can not be empty"));
        }



    }
}
