using Azure.Core;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories.Dogs
{
    public class DogRepository : IDogRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<DogRepository> _logger;

        public DogRepository(AppDbContext dbContext, ILogger<DogRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public Task<List<Dog>> GetAllDogs(CancellationToken cancellationToken)
        {
            try
            {
                List<Dog> allDogsFromDatabase = _dbContext.Dogs.ToList();

                foreach (var dog in allDogsFromDatabase)
                {
                    var userDog = _dbContext.UserDog.FirstOrDefault(ud => ud.DogId == dog.Id);

                    if (userDog != null)
                    {
                        var user = _dbContext.Users.FirstOrDefault(u => u.Id == userDog.UserId);
                        dog.OwnerDogUserName = user!.Username;
                    }
                }

                return Task.FromResult(allDogsFromDatabase);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all dogs from the database");
                throw new Exception("An error occurred while getting all dogs from the database", ex);
            }
        }

        public Task<Dog> GetDogById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                Dog wantedDog = _dbContext.Dogs.FirstOrDefault(dog => dog.Id == id)!;
                return Task.FromResult(wantedDog);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all dogs from the database");
                throw new Exception("An error occurred while getting all dogs from the database", ex);
            }
        }

        public Task<List<Dog>> GetAllDogsByCriteria(string? breed, int? weight, CancellationToken cancellationToken)
        {
            try
            {
                List<Dog> filteredDogs = _dbContext.Dogs
                                        .Where(d => (string.IsNullOrEmpty(breed) || d.Breed == breed) &&
                                        (weight == null || d.Weight >= weight))
                                        .ToList();

                return Task.FromResult(filteredDogs);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all dogs from the database");
                throw new Exception("An error occurred while getting all dogs from the database", ex);
            }
        }

        public Task<Dog> AddDog(Dog newdog, CancellationToken cancellationToken)
        {
            try
            {
                var user = _dbContext.Users
                    .FirstOrDefault(u => u.Username == newdog.OwnerDogUserName);

                if (user == null)
                {
                    // Handle the case where the user is not found
                    _logger.LogError($"Username {newdog.OwnerDogUserName} not found");
                    throw new Exception($"Username {newdog.OwnerDogUserName} not found");
                }

                newdog.UserDog = new List<UserDog>
                {
                    new UserDog { UserId = user.Id , DogId = newdog.Id},
                };

                _dbContext.Dogs.Add(newdog);
                _dbContext.SaveChangesAsync(cancellationToken);

                return Task.FromResult(newdog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while adding a dog to the database");
                throw new Exception("An error occurred while adding a dog to the database", ex);
            }
        }

        public Task<Dog> UpdateDog(Guid id, string newName, bool likesToPlay, string breed, int weight, CancellationToken cancellationToken)
        {
            try
            {
                Dog dogToUpdate = _dbContext.Dogs.FirstOrDefault(dog => dog.Id == id)!;

                dogToUpdate.Name = newName;
                dogToUpdate.LikesToPlay = likesToPlay;
                dogToUpdate.Breed = breed;
                dogToUpdate.Weight = weight;

                _dbContext.SaveChangesAsync();

                return Task.FromResult(dogToUpdate);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting a dog with ID {id} from the database");
                throw new Exception($"An error occurred while deleting a dog with ID {id} from the database", ex);
            }
        }

        public Task<Dog> DeleteDog(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var dogToDelete = _dbContext.Dogs.FirstOrDefault(d => d.Id == id);

                _dbContext.Dogs.Remove(dogToDelete!);
                _dbContext.SaveChangesAsync();
                return Task.FromResult(dogToDelete!);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting a dog with ID {id} from the database");
                throw new Exception($"An error occurred while deleting a dog with ID {id} from the database", ex);
            }

        }

    }
}
