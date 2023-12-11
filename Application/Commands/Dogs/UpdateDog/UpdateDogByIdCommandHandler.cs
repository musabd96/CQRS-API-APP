using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Dogs.UpdateDog
{
    public class UpdateDogByIdCommandHandler : IRequestHandler<UpdateDogByIdCommand, Dog>
    {
        private readonly AppDbContext _dbContext;

        public UpdateDogByIdCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Dog> Handle(UpdateDogByIdCommand request, CancellationToken cancellationToken)
        {
            Dog dogToUpdate = _dbContext.Dogs.FirstOrDefault(dog => dog.Id == request.Id)!;

            if (dogToUpdate != null)
            {
                if (string.IsNullOrWhiteSpace(request.UpdatedDog.Name) || request.UpdatedDog.Name == "string")
                {
                    return Task.FromResult<Dog>(null!);
                }
                else
                {
                    dogToUpdate.Name = request.UpdatedDog.Name;
                    dogToUpdate.LikesToPlay = request.UpdatedDog.LikesToPlay;

                    _dbContext.SaveChangesAsync();

                    return Task.FromResult(dogToUpdate);
                }

            }

            return Task.FromResult(dogToUpdate)!;
        }
    }
}
