using Domain.Models;
using Infrastructure.Repositories.Birds;
using MediatR;

namespace Application.Commands.Birds.UpdateBird
{
    public class UpdateBirdByIdCommandHandler : IRequestHandler<UpdateBirdByIdCommand, Bird>
    {
        private readonly IBirdRepository _birdRepository;

        public UpdateBirdByIdCommandHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository;
        }

        public async Task<Bird> Handle(UpdateBirdByIdCommand request, CancellationToken cancellationToken)
        {
            var Id = request.Id;
            var Name = request.UpdatedBird.Name;
            var Color = request.UpdatedBird.Color;
            var LikesToPlay = request.UpdatedBird.LikesToPlay;

            Bird birdToUpdate = await _birdRepository.UpdateBird(Id, Name, Color, LikesToPlay, cancellationToken);

            return birdToUpdate;
        }
    }
}
