using Domain.Models;
using Infrastructure.Repositories.Cats;
using MediatR;

namespace Application.Queries.Cats.GetbyBreed
{
    public sealed class GetAllCatsByCriteriaQueryHandler : IRequestHandler<GetAllCatsByCriteriaQuery, List<Cat>>
    {
        private readonly ICatRepository _catRepository;

        public GetAllCatsByCriteriaQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        public async Task<List<Cat>> Handle(GetAllCatsByCriteriaQuery request, CancellationToken cancellationToken)
        {
            List<Cat> cats = await _catRepository.GetAllCatsByCriteria(request.breed, request.weight, cancellationToken);

            return cats;
        }
    }
}
