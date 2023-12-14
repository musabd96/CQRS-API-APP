using Domain.Models;
using Infrastructure.Database;
using Infrastructure.Repositories.Birds;
using Infrastructure.Repositories.Dogs;
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
                LikesToPlay = request.NewBird.LikesToPlay
            };

            _birdRepository.AddBird(birdToCreate, cancellationToken);

            return Task.FromResult(birdToCreate);

        }
    }
}
