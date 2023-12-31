﻿using Azure.Core;
using Domain.Models;
using Infrastructure.Database;
using Microsoft.Extensions.Logging;
using System.Linq;

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

                foreach (var bird in allBirdsFromDatabase)
                {
                    var userBird = _dbContext.UserBird.FirstOrDefault(ub => ub.BirdId == bird.Id);

                    if (userBird != null)
                    {
                        var user = _dbContext.Users.FirstOrDefault(u => u.Id == userBird.UserId);
                        bird.OwnerUserName = user!.Username;
                    }
                }

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

                var userBird = _dbContext.UserBird.FirstOrDefault(ub => ub.BirdId == wantedBird.Id);
                if (userBird != null)
                {
                    var user = _dbContext.Users.FirstOrDefault(u => u.Id == userBird.UserId);
                    wantedBird.OwnerUserName = user!.Username;
                }
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
                List<Bird> filteredCirds = _dbContext.Birds
                    .Where(b => b.Color == color).ToList();

                foreach (var bird in filteredCirds)
                {
                    var userBird = _dbContext.UserBird.FirstOrDefault(ub => ub.BirdId == bird.Id);

                    if (userBird != null)
                    {
                        var user = _dbContext.Users.FirstOrDefault(u => u.Id == userBird.UserId);
                        bird.OwnerUserName = user!.Username;
                    }
                }
                return Task.FromResult(filteredCirds);
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
                var user = _dbContext.Users
                    .FirstOrDefault(u => u.Username == newbird.OwnerUserName);

                if (user == null)
                {
                    // Handle the case where the user is not found
                    _logger.LogError($"Username {newbird.OwnerUserName} not found");
                    throw new Exception($"Username {newbird.OwnerUserName} not found");
                }

                newbird.UserBird = new List<UserBird>
                {
                    new UserBird { UserId = user.Id , BirdId = newbird.Id},
                };

                newbird.TypeOfAnimal = "Bird";
                newbird.animalCanDo = "This animal can fly";

                _dbContext.Birds.Add(newbird);
                _dbContext.SaveChangesAsync(cancellationToken);

                return Task.FromResult(newbird);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while adding a bird to the database");
                throw new Exception("An error occurred while adding a bird to the database", ex);

            }
        }

        public Task<Bird> UpdateBird(Guid id, string newName, string color, bool likesToPlay, string OwnerBirdUserName, CancellationToken cancellationToken)
        {
            try
            {
                Bird birdToUpdate = _dbContext.Birds.FirstOrDefault(bird => bird.Id == id)!;

                birdToUpdate.Name = newName;
                birdToUpdate.Color = color;
                birdToUpdate.LikesToPlay = likesToPlay;
                birdToUpdate.OwnerUserName = OwnerBirdUserName;

                var user = _dbContext.Users
                    .FirstOrDefault(u => u.Username == birdToUpdate.OwnerUserName);
                if (user != null)
                {
                    birdToUpdate.UserBird = new List<UserBird>
                    {
                        new UserBird { UserId = user.Id , BirdId = birdToUpdate.Id},
                    };
                }

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
