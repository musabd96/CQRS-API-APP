using Application.Queries.Cats.GettAll;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Cats
{
    public class GetAllCatsQueryhandler : IRequestHandler<GetAllCatsQuery, List<Cat>>
    {
        private readonly MockDatabase _mockDatabase;

        public GetAllCatsQueryhandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<List<Cat>> Handle(GetAllCatsQuery request, CancellationToken cancellationToken)
        {
            if (_mockDatabase == null)
            {
                return Task.FromResult<List<Cat>>(null);
            }
            List<Cat> allCatsFromMockDatabase = _mockDatabase.Cats ?? new List<Cat>();
            return Task.FromResult(allCatsFromMockDatabase);
        }
    }
}
