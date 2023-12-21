using Domain.Models;
using Domain.Models.Animal;

namespace Infrastructure.Repositories.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> RegisterUser(User userToRegister);
        Task<List<AnimalModel>> GetAllAnimals(string username, CancellationToken cancellationToken);
        Task<List<AnimalModel>> AddAnimal(string username, AnimalModel newAnimal, CancellationToken cancellationToken);
    }
}
