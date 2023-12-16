using Domain.Models;

namespace Infrastructure.Repositories.Dogs
{
    public interface IDogRepository
    {
        Task<List<Dog>> GetAllDogs(CancellationToken cancellationToken);
        Task<Dog> GetDogById(Guid id, CancellationToken cancellationToken);
        Task<List<Dog>> GetAllDogsByBreed(string breed, CancellationToken cancellationToken);
        Task<List<Dog>> GetAllDogsByWeight(int weight, CancellationToken cancellationToken);
        Task<Dog> AddDog(Dog newdog, CancellationToken cancellationToken);
        Task<Dog> UpdateDog(Guid id, string newName, bool likesToPlay, string breed, CancellationToken cancellationToken);
        Task<Dog> DeleteDog(Guid id, CancellationToken cancellationToken);
    }
}
