using Infrastructure.Repositories.Authorization;
using Moq;
using Application.Queries.Users.Login;
using Domain.Models;
using Application.Dtos.Users;

namespace Test.QueryTests.Users
{
    [TestFixture]
    public class LoginUserQueryHandlerTests
    {
        private LoginUserQueryHandler _handler;
        private Mock<IAuthRepository> _authRepository;

        [SetUp]
        public void Setup()
        {
            _authRepository = new Mock<IAuthRepository>();
            _handler = new LoginUserQueryHandler(_authRepository.Object);
        }


        private void SetupMockUserRepository(List<User> users)
        {
            _authRepository.Setup(repo => repo.AuthenticateUser(It.IsAny<string>(), It.IsAny<string>()))
                          .Returns<string, string>((username, password) =>
                          {
                              return users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password)!;
                          });

            _authRepository.Setup(repo => repo.GenerateJwtToken(It.IsAny<User>()))
                          .Returns("fakeJwtToken");
        }

        [Test]
        public async Task Handle_ValidLogin_ReturnsToken()
        {
            // Arrange
            var users = new List<User>
            {
                new User { Username = "Testing", PasswordHash = "Password1!" }
            };

            SetupMockUserRepository(users);

            var loginUserQuery = new LoginUserQuery(new UserDto
            {
                Username = "Testing",
                Password = "Password1!"
            });

            // Act
            var result = await _handler.Handle(loginUserQuery, CancellationToken.None);

            // Assert
            Assert.That(result, Is.EqualTo("fakeJwtToken"));
        }

        [Test]
        public void Handle_InvalidLogin_ThrowsUnauthorizedAccessException()
        {
            // Arrange
            var users = new List<User>();
            SetupMockUserRepository(users);

            var loginUserQuery = new LoginUserQuery(new UserDto
            {
                Username = "nonexistentUser",
                Password = "incorrectPassword1!"
            });

            // Act & Assert
            Assert.ThrowsAsync<UnauthorizedAccessException>(() => 
                _handler.Handle(loginUserQuery, CancellationToken.None));
        }

    }
}
