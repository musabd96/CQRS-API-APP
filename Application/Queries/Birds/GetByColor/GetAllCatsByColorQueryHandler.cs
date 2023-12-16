using Domain.Models;
using Infrastructure.Repositories.Birds;
using MediatR;

namespace Application.Queries.Birds.GetByColor
{
    public sealed class GetAllCatsByColorQueryHandler : IRequestHandler<GetAllCatsByColorQuery, List<Bird>>
    {
        private readonly IBirdRepository _birdRepository;

        public GetAllCatsByColorQueryHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository;
        }

        public async Task<List<Bird>> Handle(GetAllCatsByColorQuery request, CancellationToken cancellationToken)
        {
            List<Bird> birds = await _birdRepository.GetAllBirdsByColor(request.color, cancellationToken);

            return birds;
        }
    }
}
