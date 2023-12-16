using Domain.Models;
using Infrastructure.Repositories.Cats;
using MediatR;

namespace Application.Queries.Cats.GetbyBreed
{
    public sealed class GetAllCatsByBreedQueryHandler : IRequestHandler<GetAllCatsByBreedQuery, List<Cat>>
    {
        private readonly ICatRepository _catRepository;

        public GetAllCatsByBreedQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        public async Task<List<Cat>> Handle(GetAllCatsByBreedQuery request, CancellationToken cancellationToken)
        {
            List<Cat> cats = await _catRepository.GetAllCatsByBreed(request.breed, cancellationToken);

            return cats;
        }
    }
}
