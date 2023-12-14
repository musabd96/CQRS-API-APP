using Domain.Models;

namespace Infrastructure.Repositories.Dogs
{
    public interface IDogRepository
    {
        Task<List<Dog>> GetAllDogs(CancellationToken cancellationToken);
        Task<Dog> GetDogById(Guid id, CancellationToken cancellationToken);
        Task<Dog> AddDog(Dog newdog, CancellationToken cancellationToken);
        Task<Dog> UpdateDog(Guid id, string newName, bool likesToPlay, CancellationToken cancellationToken);
        Task<Dog> DeleteDog(Guid id, CancellationToken cancellationToken);
    }
}
