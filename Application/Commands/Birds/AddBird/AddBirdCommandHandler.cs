using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Birds.AddBird
{
    public class AddBirdCommandHandler : IRequestHandler<AddBirdCommand, Bird>
    {
        private readonly AppDbContext _dbContext;

        public AddBirdCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Bird> Handle(AddBirdCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.NewBird.Name) || request.NewBird.Name == "string")
            {
                return Task.FromResult<Bird>(null!);
            }
            else
            {
                Bird birdToCreate = new()
                {
                    Id = Guid.NewGuid(),
                    Name = request.NewBird.Name,
                    LikesToPlay = request.NewBird.LikesToPlay
                };

                _dbContext.Birds.Add(birdToCreate);
                _dbContext.SaveChangesAsync();

                return Task.FromResult(birdToCreate);
            }


        }
    }
}
