using Domain.Models;
using Infrastructure.Database;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repositories.Birds
{
    public class BirdRepository : IBirdRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<BirdRepository> _logger;

        public BirdRepository(AppDbContext dbContext, ILogger<BirdRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public Task<List<Bird>> GetAllBirds(CancellationToken cancellationToken)
        {
            try
            {
                List<Bird> allBirdsFromDatabase = _dbContext.Birds.ToList();

                return Task.FromResult(allBirdsFromDatabase);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all dogs from the database");
                throw new Exception("An error occurred while getting all dogs from the database", ex);
            }
        }

        public Task<Bird> GetBirdById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                Bird wantedBird = _dbContext.Birds.FirstOrDefault(bird => bird.Id == id)!;
                return Task.FromResult(wantedBird);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all dogs from the database");
                throw new Exception("An error occurred while getting all dogs from the database", ex);
            }
        }

        public Task<List<Bird>> GetAllBirdsByColor(string color, CancellationToken cancellationToken)
        {
            try
            {
                List<Bird> birds = _dbContext.Birds
                    .Where(b => b.Color == color).ToList();

                return Task.FromResult(birds);
            }
            catch (Exception ex)
            {
                _logger.LogError("An error occurred while getting all catss from the database");
                throw new Exception("An error occurred while getting all catss from the database", ex);
            }
        }

        public Task<Bird> AddBird(Bird newbird, CancellationToken cancellationToken)
        {
            try
            {
                _dbContext.Birds.Add(newbird);
                _dbContext.SaveChangesAsync();

                return Task.FromResult(newbird);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while adding a dog to the database");
                throw new Exception("An error occurred while adding a dog to the database", ex);
            }
        }

        public Task<Bird> UpdateBird(Guid id, string newName, bool likesToPlay, CancellationToken cancellationToken)
        {
            try
            {
                Bird birdToUpdate = _dbContext.Birds.FirstOrDefault(bird => bird.Id == id)!;

                birdToUpdate.Name = newName;
                birdToUpdate.LikesToPlay = likesToPlay;

                _dbContext.SaveChangesAsync();

                return Task.FromResult(birdToUpdate);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting a dog with ID {id} from the database");
                throw new Exception($"An error occurred while deleting a dog with ID {id} from the database", ex);
            }
        }

        public Task<Bird> DeleteBird(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var birdToDelete = _dbContext.Birds.FirstOrDefault(bird => bird.Id == id);

                _dbContext.Birds.Remove(birdToDelete!);
                _dbContext.SaveChangesAsync();
                return Task.FromResult(birdToDelete!);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting a dog with ID {id} from the database");
                throw new Exception($"An error occurred while deleting a dog with ID {id} from the database", ex);
            }

        }
    }
}
