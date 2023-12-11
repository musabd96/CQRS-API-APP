using Application.Queries.Cats.GettAll;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Cats
{
    public class GetAllCatsQueryhandler : IRequestHandler<GetAllCatsQuery, List<Cat>>
    {
        private readonly AppDbContext _dbContext;

        public GetAllCatsQueryhandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Cat>> Handle(GetAllCatsQuery request, CancellationToken cancellationToken)
        {
            List<Cat> allCatsFromDb = _dbContext.Cats.ToList();
            return Task.FromResult(allCatsFromDb);
        }
    }
}
