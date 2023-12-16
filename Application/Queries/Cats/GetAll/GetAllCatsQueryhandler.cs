using Application.Queries.Cats.GettAll;
using Domain.Models;
using Infrastructure.Repositories.Cats;
using MediatR;

namespace Application.Queries.Cats
{
    public class GetAllCatsQueryhandler : IRequestHandler<GetAllCatsQuery, List<Cat>>
    {
        private readonly ICatRepository _catRepository;

        public GetAllCatsQueryhandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        public Task<List<Cat>> Handle(GetAllCatsQuery request, CancellationToken cancellationToken)
        {
            List<Cat> allCatsFromMockDatabase = Task.Run(() => _catRepository.GetAllCats(cancellationToken)).Result;

            return Task.FromResult(allCatsFromMockDatabase);
        }
    }
}
