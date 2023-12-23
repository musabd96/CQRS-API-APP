using Domain.Models;
using Domain.Models.Animal;
using System;

namespace Infrastructure.Repositories.Users
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> RegisterUser(User userToRegister);
        Task<List<AnimalModel>> GetAllAnimals(string username, CancellationToken cancellationToken);
        Task<List<AnimalModel>> AddAnimal(string username, AnimalModel newAnimal, CancellationToken cancellationToken);
        Task<AnimalModel> UpdateAnimal(string userName, Guid id, string newName,
                                             bool likesToPlay, string breed,
                                             int weight, string color,
                                             CancellationToken cancellationToken);
        Task<AnimalModel> DeleteAnimal(Guid id, string userName, CancellationToken cancellationToken);
    }
}
