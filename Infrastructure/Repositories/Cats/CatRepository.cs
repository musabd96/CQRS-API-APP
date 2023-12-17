using Domain.Models;
using Infrastructure.Database;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories.Cats
{
    public class CatRepository : ICatRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<CatRepository> _logger;

        public CatRepository(AppDbContext dbContext, ILogger<CatRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        public Task<List<Cat>> GetAllCats(CancellationToken cancellationToken)
        {
            try
            {
                List<Cat> allCatsFromDatabase = _dbContext.Cats.ToList();

                foreach (var cat in allCatsFromDatabase)
                {
                    var userCat = _dbContext.UserCat.FirstOrDefault(uc => uc.CatId == cat.Id);

                    if (userCat != null)
                    {
                        var user = _dbContext.Users.FirstOrDefault(u => u.Id == userCat.UserId);
                        cat.OwnerCatUserName = user!.Username;
                    }
                }

                return Task.FromResult(allCatsFromDatabase);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all birds from the database");
                throw new Exception("An error occurred while getting all birds from the database", ex);
            }
        }

        public Task<Cat> GetCatById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                Cat wantedCat = _dbContext.Cats.FirstOrDefault(cat => cat.Id == id)!;
                var userCat = _dbContext.UserCat.FirstOrDefault(uc => uc.CatId == wantedCat.Id);

                if (userCat != null)
                {
                    var user = _dbContext.Users.FirstOrDefault(u => u.Id == userCat.UserId);
                    wantedCat.OwnerCatUserName = user!.Username;
                }
                return Task.FromResult(wantedCat);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all birds from the database");
                throw new Exception("An error occurred while getting all birds from the database", ex);
            }
        }

        public Task<List<Cat>> GetAllCatsByCriteria(string? breed, int? weight, CancellationToken cancellationToken)
        {
            try
            {
                List<Cat> filteredCats = _dbContext.Cats
                                        .Where(c => (string.IsNullOrEmpty(breed) || c.Breed == breed) &&
                                        (weight == null || c.Weight >= weight))
                                        .ToList();

                return Task.FromResult(filteredCats);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all catss from the database");
                throw new Exception("An error occurred while getting all catss from the database", ex);
            }
        }

        public Task<Cat> AddCat(Cat newcat, CancellationToken cancellationToken)
        {
            try
            {
                var user = _dbContext.Users
                    .FirstOrDefault(u => u.Username == newcat.OwnerCatUserName);

                if (user == null)
                {
                    // Handle the case where the user is not found
                    _logger.LogError($"Username {newcat.OwnerCatUserName} not found");
                    throw new Exception($"Username {newcat.OwnerCatUserName} not found");
                }

                newcat.UserCat = new List<UserCat>
                {
                    new UserCat { UserId = user.Id , CatId = newcat.Id},
                };

                _dbContext.Cats.Add(newcat);
                _dbContext.SaveChangesAsync(cancellationToken);

                return Task.FromResult(newcat);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while adding a cat to the database");
                throw new Exception("An error occurred while adding a cat to the database", ex);
            }
        }

        public Task<Cat> UpdateCat(Guid id, string newName, bool likesToPlay, string breed, int weight, CancellationToken cancellationToken)
        {
            try
            {
                Cat catToUpdate = _dbContext.Cats.FirstOrDefault(at => at.Id == id)!;

                catToUpdate.Name = newName;
                catToUpdate.LikesToPlay = likesToPlay;
                catToUpdate.Breed = breed;
                catToUpdate.Weight = weight;

                _dbContext.SaveChangesAsync();

                return Task.FromResult(catToUpdate);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting a cat with ID {id} from the database");
                throw new Exception($"An error occurred while deleting a cat with ID {id} from the database", ex);
            }
        }

        public Task<Cat> DeleteCat(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var catToDelete = _dbContext.Cats.FirstOrDefault(cat => cat.Id == id);

                _dbContext.Cats.Remove(catToDelete!);
                _dbContext.SaveChangesAsync();
                return Task.FromResult(catToDelete!);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting a cat with ID {id} from the database");
                throw new Exception($"An error occurred while deleting a cat with ID {id} from the database", ex);
            }
        }



    }
}
