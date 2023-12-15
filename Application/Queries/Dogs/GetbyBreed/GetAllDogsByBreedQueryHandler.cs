using Domain.Models;
using Infrastructure.Repositories.Dogs;
using MediatR;

namespace Application.Queries.Dogs.GetbyBreed
{
    public sealed class GetAllDogsByBreedQueryHandler : IRequestHandler<GetAllDogsByBreedQuery, List<Dog>>
    {
        private readonly IDogRepository _dogRepository;

        public GetAllDogsByBreedQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }
        public async Task<List<Dog>> Handle(GetAllDogsByBreedQuery request, CancellationToken cancellationToken)
        {
            List<Dog> dogs = await _dogRepository.GetAllDogsByBreed(request.breed, cancellationToken);

            return dogs;
        }
    }
}
