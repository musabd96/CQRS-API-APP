using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Birds.UpdateBird
{
    public class UpdateBirdByIdCommandHandler : IRequestHandler<UpdateBirdByIdCommand, Bird>
    {
        private readonly AppDbContext _dbContext;

        public UpdateBirdByIdCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Bird> Handle(UpdateBirdByIdCommand request, CancellationToken cancellationToken)
        {
            Bird birdToUpdate = _dbContext.Birds.FirstOrDefault(bird => bird.Id == request.Id)!;

            if (birdToUpdate != null)
            {
                if (string.IsNullOrWhiteSpace(request.UpdatedBird.Name) || request.UpdatedBird.Name == "string")
                {
                    return Task.FromResult<Bird>(null!);
                }
                else
                {
                    birdToUpdate.Name = request.UpdatedBird.Name;
                    birdToUpdate.LikesToPlay = request.UpdatedBird.LikesToPlay;

                    _dbContext.SaveChangesAsync();

                    return Task.FromResult(birdToUpdate);
                }

            }

            return Task.FromResult(birdToUpdate)!;
        }
    }
}
