namespace Application.Dtos.Users
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
