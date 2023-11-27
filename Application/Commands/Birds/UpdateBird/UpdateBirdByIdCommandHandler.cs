using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Birds.UpdateBird
{
    public class UpdateBirdByIdCommandHandler : IRequestHandler<UpdateBirdByIdCommand, Bird>
    {
        private readonly MockDatabase _mockDatabase;

        public UpdateBirdByIdCommandHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<Bird> Handle(UpdateBirdByIdCommand request, CancellationToken cancellationToken)
        {
            Bird birdToUpdate = _mockDatabase.Birds.FirstOrDefault(bird => bird.Id == request.Id)!;

            if (birdToUpdate != null)
            {
                birdToUpdate.Name = request.UpdatedBird.Name;
                birdToUpdate.LikesToPlay = request.UpdatedBird.LikesToPlay;
                return Task.FromResult(birdToUpdate);
            }

            return Task.FromResult(birdToUpdate);
        }
    }
}
