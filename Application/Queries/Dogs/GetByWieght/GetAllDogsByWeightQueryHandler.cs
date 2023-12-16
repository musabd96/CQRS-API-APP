using Domain.Models;
using Infrastructure.Repositories.Cats;
using Infrastructure.Repositories.Dogs;
using MediatR;

namespace Application.Queries.Dogs.GetByWieght
{
    public sealed class GetAllDogsByWeightQueryHandler : IRequestHandler<GetAllDogsByWeightQuery, List<Dog>>
    {
        private readonly IDogRepository _dogRepository;

        public GetAllDogsByWeightQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public async Task<List<Dog>> Handle(GetAllDogsByWeightQuery request, CancellationToken cancellationToken)
        {
            List<Dog> dogs = await _dogRepository.GetAllDogsByWeight(request.weight, cancellationToken);

            return dogs;
        }
    }
}
