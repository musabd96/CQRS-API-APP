using Moq;
using Application.Commands.Users.Register;
using Application.Dtos.Users;
using Infrastructure.Repositories.Users;
using Domain.Models;

namespace Test.CommandTests.Users
{
    [TestFixture]
    public class RegisterUser
    {
        private RegisterUserCommandHandler _handler;
        private Mock<IUserRepository> _userRepository;
        private RegisterUserCommandValidator _validator;

        [SetUp]
        public void Setup()
        {
            _userRepository = new Mock<IUserRepository>();
            _validator = new RegisterUserCommandValidator(_userRepository.Object);
            _handler = new RegisterUserCommandHandler(_userRepository.Object, _validator);
        }

        private void SetupMockUserRepository(List<User> users)
        {
            _userRepository.Setup(repo => repo.GetAllUsers())
                   .ReturnsAsync(users);

            _userRepository.Setup(repo => repo.RegisterUser(It.IsAny<User>()))
                           .ReturnsAsync((User newUser) =>
                           {
                               users.Add(newUser);
                               return newUser;
                           });
        }

        [Test]
        public async Task Handle_ValidCommand_CreatedUser()
        {
            // Arrange
            var users = new List<User>();
            SetupMockUserRepository(users);

            var command = new RegisterUserCommand(new UserDto
            {
                Username = "testuser",
                Password = "Password1!"
            });

            // Act
            var result = await _handler.Handle(command, CancellationToken.None);

            // Assert
            Assert.That(result.Username, Is.EqualTo("testuser"));
        }

        [Test]
        public void Handle_InValidCommand_EmptyUserName()
        {
            // Arrange
            var users = new List<User>();
            SetupMockUserRepository(users);
            var command = new RegisterUserCommand(
                new UserDto
                {
                    Username = "",
                    Password = "Password1!"
                });

            // Act & Assert
            Assert.ThrowsAsync<ArgumentException>(() => _handler.Handle(command, CancellationToken.None));
        }

    }
}
