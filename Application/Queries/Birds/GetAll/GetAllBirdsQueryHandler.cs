using Domain.Models;
using Infrastructure.Database;
using Infrastructure.Repositories.Birds;
using Infrastructure.Repositories.Dogs;
using MediatR;

namespace Application.Queries.Birds.GetAll
{
    public class GetAllBirdsQueryHandler : IRequestHandler<GetAllBirdsQuery, List<Bird>>
    {
        private readonly IBirdRepository _birdRepository;

        public GetAllBirdsQueryHandler(IBirdRepository birdRepository)
        {
            _birdRepository = birdRepository;
        }
        public Task<List<Bird>> Handle(GetAllBirdsQuery request, CancellationToken cancellationToken)
        {
            List<Bird> allBirdsFromMockDatabase = Task.Run(() => _birdRepository.GetAllBirds(cancellationToken)).Result;

            return Task.FromResult(allBirdsFromMockDatabase);
        }
    }
}
