using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Database;

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

        public Task<AnimalModel> GetAnimalById(Guid id, string username, CancellationToken cancellationToken)
        {
            try
            {
                var user = _dbContext.Users
                    .FirstOrDefault(u => u.Username == username);

                UserBird bird = _dbContext.UserBird.FirstOrDefault(b => b.BirdId == id)!;
                UserCat cat = _dbContext.UserCat.FirstOrDefault(c => c.CatId == id)!;
                UserDog dog = _dbContext.UserDog.FirstOrDefault(d => d.DogId == id)!;

                if (bird != null)
                {
                    Bird userBird = _dbContext.Birds.FirstOrDefault(b => b.Id == id)!;
                    userBird.OwnerUserName = username;

                    return Task.FromResult<AnimalModel>(userBird);
                }
                else if (cat != null)
                {
                    Cat userCat = _dbContext.Cats.FirstOrDefault(c => c.Id == id)!;
                    userCat.OwnerUserName = username;

                    return Task.FromResult<AnimalModel>(userCat);
                }
                else if (dog != null)
                {
                    Dog userDog = _dbContext.Dogs.FirstOrDefault(d => d.Id == id)!;
                    userDog.OwnerUserName = username;

                    return Task.FromResult<AnimalModel>(userDog);
                }
                else
                {
                    throw new Exception($"This animal ID {id} is not your pet");
                }
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
                        animalCanDo = newAnimal.animalCanDo,
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
                        animalCanDo = newAnimal.animalCanDo,
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
                        animalCanDo = newAnimal.animalCanDo,
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


        public Task<AnimalModel> UpdateAnimal(string userName, Guid id, string newName, bool likesToPlay, string breed, int weight, string color, CancellationToken cancellationToken)
        {
            try
            {
                var user = _dbContext.Users
                    .FirstOrDefault(u => u.Username == userName);

                UserBird birdToUpdate = _dbContext.UserBird.FirstOrDefault(b => b.BirdId == id)!;
                UserCat catToUpdate = _dbContext.UserCat.FirstOrDefault(c => c.CatId == id)!;
                UserDog dogToUpdate = _dbContext.UserDog.FirstOrDefault(d => d.DogId == id)!;

                if (birdToUpdate != null)
                {
                    Bird birdUpdate = _dbContext.Birds.FirstOrDefault(b => b.Id == id)!;

                    birdUpdate.Name = newName;
                    birdUpdate.Color = color;
                    birdUpdate.LikesToPlay = likesToPlay;
                    birdUpdate.OwnerUserName = userName;


                    AnimalModel updatedAnimal = new AnimalModel()
                    {
                        Id = id,
                        Name = newName,
                        LikesToPlay = likesToPlay,
                        Color = color,
                    };

                    _dbContext.SaveChangesAsync(cancellationToken);

                    return Task.FromResult(updatedAnimal);
                }
                else if (catToUpdate != null)
                {
                    Cat catUpdate = _dbContext.Cats.FirstOrDefault(c => c.Id == id)!;

                    catUpdate.Name = newName;
                    catUpdate.Weight = weight;
                    catUpdate.Breed = breed;
                    catUpdate.LikesToPlay = likesToPlay;
                    catUpdate.OwnerUserName = userName;

                    AnimalModel updatedAnimal = new AnimalModel()
                    {
                        Id = id,
                        Name = newName,
                        LikesToPlay = likesToPlay,
                        Breed = breed,
                        Weight = weight,
                    };
                    _dbContext.SaveChangesAsync(cancellationToken);

                    return Task.FromResult(updatedAnimal);
                }
                else if (dogToUpdate != null)
                {
                    Dog dogUpdate = _dbContext.Dogs.FirstOrDefault(d => d.Id == id)!;

                    dogUpdate.Name = newName;
                    dogUpdate.Weight = weight;
                    dogUpdate.Breed = breed;
                    dogUpdate.LikesToPlay = likesToPlay;
                    dogUpdate.OwnerUserName = userName;

                    AnimalModel updatedAnimal = new AnimalModel()
                    {
                        Id = id,
                        Name = newName,
                        LikesToPlay = likesToPlay,
                        Breed = breed,
                        Weight = weight,
                    };
                    _dbContext.SaveChangesAsync(cancellationToken);

                    return Task.FromResult(updatedAnimal);
                }
                else
                {
                    throw new Exception($"This animal ID {id} is not your pet");
                }


            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting a animal with ID {id} from the database", ex);
            }
        }

        public Task<AnimalModel> DeleteAnimal(Guid id, string userName, CancellationToken cancellationToken)
        {
            try
            {
                var user = _dbContext.Users
                    .FirstOrDefault(u => u.Username == userName);

                UserBird birdToDelete = _dbContext.UserBird.FirstOrDefault(b => b.BirdId == id)!;
                UserCat catToDelete = _dbContext.UserCat.FirstOrDefault(c => c.CatId == id)!;
                UserDog dogToDelete = _dbContext.UserDog.FirstOrDefault(d => d.DogId == id)!;

                if (birdToDelete != null)
                {
                    _dbContext.UserBird.Remove(birdToDelete);


                    _dbContext.SaveChangesAsync(cancellationToken);

                    return Task.FromResult(new AnimalModel()
                    {
                        Id = id,
                    });
                }
                else if (catToDelete != null)
                {
                    _dbContext.UserCat.Remove(catToDelete);

                    AnimalModel deleteAnimal = new AnimalModel()
                    {
                        Id = id,
                    };

                    _dbContext.SaveChangesAsync(cancellationToken);

                    return Task.FromResult(deleteAnimal);
                }
                else if (dogToDelete != null)
                {
                    _dbContext.UserDog.Remove(dogToDelete);

                    AnimalModel deleteAnimal = new AnimalModel()
                    {
                        Id = id,
                    };

                    _dbContext.SaveChangesAsync(cancellationToken);

                    return Task.FromResult(deleteAnimal);
                }
                else
                {
                    throw new Exception($"This animal ID {id} is not your pet");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting an animal with ID {id} from the database", ex);
            }
        }

    }
}
