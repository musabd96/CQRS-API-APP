using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Birds.GetAll
{
    public class GetAllBirdsQueryHandler : IRequestHandler<GetAllBirdsQuery, List<Bird>>
    {
        private readonly AppDbContext _dbContext;

        public GetAllBirdsQueryHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<List<Bird>> Handle(GetAllBirdsQuery request, CancellationToken cancellationToken)
        {
            List<Bird> allBirdsFromMockDatabase = _dbContext.Birds.ToList();

            return Task.FromResult(allBirdsFromMockDatabase);
        }
    }
}
