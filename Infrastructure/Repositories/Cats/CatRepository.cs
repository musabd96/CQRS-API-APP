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
                return Task.FromResult(wantedCat);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all birds from the database");
                throw new Exception("An error occurred while getting all birds from the database", ex);
            }
        }

        public Task<List<Cat>> GetAllCatsByBreed(string breed, CancellationToken cancellationToken)
        {
            try
            {
                List<Cat> cats = _dbContext.Cats
                    .Where(c => c.Breed == breed).ToList();

                return Task.FromResult(cats);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all catss from the database");
                throw new Exception("An error occurred while getting all catss from the database", ex);
            }
        }

        public Task<List<Cat>> GetAllDogsByWeight(int weight, CancellationToken cancellationToken)
        {
            try
            {
                List<Cat> cats = _dbContext.Cats
                    .Where(c => c.Weight == weight).ToList();

                return Task.FromResult(cats);
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
                _dbContext.Cats.Add(newcat);
                _dbContext.SaveChangesAsync();

                return Task.FromResult(newcat);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while adding a cat to the database");
                throw new Exception("An error occurred while adding a cat to the database", ex);
            }
        }

        public Task<Cat> UpdateCat(Guid id, string newName, bool likesToPlay, string breed, CancellationToken cancellationToken)
        {
            try
            {
                Cat catToUpdate = _dbContext.Cats.FirstOrDefault(at => at.Id == id)!;

                catToUpdate.Name = newName;
                catToUpdate.LikesToPlay = likesToPlay;
                catToUpdate.Breed = breed;

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
