using Azure.Core;
using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Database;
using System.Drawing;
using System.Security.Principal;

namespace Infrastructure.Repositories.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> RegisterUser(User userToRegister)
        {
            try
            {
                _dbContext.Users.Add(userToRegister);
                _dbContext.SaveChanges();
                return await Task.FromResult(userToRegister);
            }
            catch (ArgumentException e)
            {
                //// Log the error and return an error response
                //_logger.LogError(e, "Error registering user");
                throw new ArgumentException(e.Message);
            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                List<User> allUsersFromDatabase = _dbContext.Users.ToList();
                return await Task.FromResult(allUsersFromDatabase);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(e.Message);
            }
        }

        public Task<List<AnimalModel>> GetAllAnimals(string username, CancellationToken cancellationToken)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(u => u.Username == username);

                List<AnimalModel> allUsersAnimals = new List<AnimalModel>();

                // Fetch only animals that the owner(user) have
                List<Bird> allBirds = _dbContext.Birds
                    .Where(bird => _dbContext.UserBird.Any(ub => ub.BirdId == bird.Id && ub.UserId == user!.Id))
                    .ToList();

                List<Cat> allCats = _dbContext.Cats
                    .Where(cat => _dbContext.UserCat.Any(uc => uc.CatId == cat.Id && uc.UserId == user!.Id))
                    .ToList();

                List<Dog> allDogs = _dbContext.Dogs
                    .Where(dog => _dbContext.UserDog.Any(ud => ud.DogId == dog.Id && ud.UserId == user!.Id))
                    .ToList();

                // Set owner username for each animal
                allBirds.ForEach(bird => bird.OwnerUserName = user!.Username);
                allCats.ForEach(cat => cat.OwnerUserName = user!.Username);
                allDogs.ForEach(dog => dog.OwnerUserName = user!.Username);

                // Add animals to the result list
                allUsersAnimals.AddRange(allBirds);
                allUsersAnimals.AddRange(allCats);
                allUsersAnimals.AddRange(allDogs);

                return Task.FromResult(allUsersAnimals);
            }
            catch (Exception ex)
            {
                //_logger.LogError("An error occurred while getting all animals from the database");
                throw new Exception("An error occurred while getting all animals from the database", ex);
            }
        }

        public Task<List<AnimalModel>> AddAnimal(string username, AnimalModel newAnimal, CancellationToken cancellationToken)
        {
            try
            {
                var user = _dbContext.Users
                    .FirstOrDefault(u => u.Username == username);



                if (newAnimal.TypeOfAnimal == "Dog")
                {

                    var dogEntity = new Dog
                    {
                        Id = newAnimal.Id,
                        Name = newAnimal.Name,
                        TypeOfAnimal = newAnimal.TypeOfAnimal,
                        LikesToPlay = newAnimal.LikesToPlay,
                        Breed = newAnimal.Breed,
                        Weight = newAnimal.Weight,
                        Color = newAnimal.Color
                    };
                    _dbContext.Dogs.Add(dogEntity);

                    var userDogEntity = new UserDog
                    {
                        UserId = user.Id,
                        DogId = dogEntity.Id
                    };
                    _dbContext.UserDog.Add(userDogEntity);

                }
                else if (newAnimal.TypeOfAnimal == "Cat")
                {
                    var catEntity = new Cat
                    {
                        Id = newAnimal.Id,
                        Name = newAnimal.Name,
                        TypeOfAnimal = newAnimal.TypeOfAnimal,
                        LikesToPlay = newAnimal.LikesToPlay,
                        Breed = newAnimal.Breed,
                        Weight = newAnimal.Weight,
                        Color = newAnimal.Color
                    };
                    _dbContext.Cats.Add(catEntity);

                    var userCatEntity = new UserCat
                    {
                        UserId = user.Id,
                        CatId = catEntity.Id
                    };

                    _dbContext.UserCat.Add(userCatEntity);
                }
                else if (newAnimal.TypeOfAnimal == "Bird")
                {
                    var birdEntity = new Bird
                    {
                        Id = newAnimal.Id,
                        Name = newAnimal.Name,
                        TypeOfAnimal = newAnimal.TypeOfAnimal,
                        LikesToPlay = newAnimal.LikesToPlay,
                        Breed = newAnimal.Breed,
                        Weight = newAnimal.Weight,
                        Color = newAnimal.Color
                    };

                    _dbContext.Birds.Add(birdEntity);

                    var userBirdEntity = new UserBird
                    {
                        UserId = user.Id,
                        BirdId = birdEntity.Id
                    };

                    _dbContext.UserBird.Add(userBirdEntity);

                }

                _dbContext.SaveChangesAsync(cancellationToken);

                return Task.FromResult(new List<AnimalModel> { newAnimal });
            }
            catch (Exception ex)
            {
                //_logger.LogError("An error occurred while getting all animals from the database");
                throw new Exception("An error occurred while getting all animals from the database", ex);
            }

        }
    }
}
