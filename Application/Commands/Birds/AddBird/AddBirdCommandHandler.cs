using Domain.Models;
using Infrastructure.Repositories.Birds;
using MediatR;

namespace Application.Commands.Birds.AddBird
{
    public class AddBirdCommandHandler : IRequestHandler<AddBirdCommand, Bird>
    {
        private readonly IBirdRepository _birdRepository;

        public AddBirdCommandHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository;
        }

        public Task<Bird> Handle(AddBirdCommand request, CancellationToken cancellationToken)
        {
            Bird birdToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewBird.Name,
                Color = request.NewBird.Color,
                LikesToPlay = request.NewBird.LikesToPlay,
                OwnerBirdUserName = request.NewBird.OwnerBirdUserName,
            };

            _birdRepository.AddBird(birdToCreate, cancellationToken);

            return Task.FromResult(birdToCreate);

        }
    }
}
