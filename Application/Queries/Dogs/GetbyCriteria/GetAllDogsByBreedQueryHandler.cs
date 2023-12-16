using Domain.Models;
using Infrastructure.Repositories.Dogs;
using MediatR;

namespace Application.Queries.Dogs.GetbyBreed
{
    public sealed class GetAllDogsByBreedQueryHandler : IRequestHandler<GetAllDogsByCriteriaQuery, List<Dog>>
    {
        private readonly IDogRepository _dogRepository;

        public GetAllDogsByBreedQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }
        public async Task<List<Dog>> Handle(GetAllDogsByCriteriaQuery request, CancellationToken cancellationToken)
        {
            List<Dog> dogs = await _dogRepository.GetAllDogsByCriteria(request.breed, request.weight, cancellationToken);

            return dogs;
        }
    }
}
