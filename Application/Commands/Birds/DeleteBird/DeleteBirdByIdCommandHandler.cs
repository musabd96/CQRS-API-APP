using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Birds.DeleteBird
{
    public class DeleteBirdByIdCommandHandler : IRequestHandler<DeleteBirdByIdCommand, Bird>
    {
        private readonly AppDbContext _dbContext;

        public DeleteBirdByIdCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Bird> Handle(DeleteBirdByIdCommand request, CancellationToken cancellationToken)
        {
            var birdToDelete = _dbContext.Birds.FirstOrDefault(bird => bird.Id == request.Id);

            if (birdToDelete != null)
            {
                _dbContext.Birds.Remove(birdToDelete);
                _dbContext.SaveChangesAsync();
                return Task.FromResult(birdToDelete);
            }

            // Cat not found
            return Task.FromResult(birdToDelete)!;
        }
    }
}
