using Application.Queries.Dogs.GetAll;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Dogs
{
    public sealed class AddDogCommandHandler : IRequestHandler<AddDogCommand, Dog>
    {
        private readonly AppDbContext _dbContext;

        public AddDogCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Dog> Handle(AddDogCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.NewDog.Name) || request.NewDog.Name == "string")
            {
                return Task.FromResult<Dog>(null!);
            }
            else
            {
                Dog dogToCreate = new()
                {
                    Id = Guid.NewGuid(),
                    Name = request.NewDog.Name,
                    LikesToPlay = request.NewDog.LikesToPlay
                };

                _dbContext.Dogs.Add(dogToCreate);
                _dbContext.SaveChangesAsync();

                return Task.FromResult(dogToCreate);
            }


        }
    }
}
