using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries.Birds.GetAll
{
    public class GetAllBirdsQueryHandler : IRequestHandler<GetAllBirdsQuery, List<Bird>>
    {
        private readonly AppDbContext? _dbContext;

        public GetAllBirdsQueryHandler(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public async Task<List<Bird>> Handle(GetAllBirdsQuery request, CancellationToken cancellationToken)
        {
            if (_dbContext == null)
            {
                // Handle the case where _dbContext is null, perhaps by returning an empty list or logging an error.
                return null!;
            }
            else
            {
                List<Bird> allBirdsFromMockDatabase = await _dbContext.Birds.ToListAsync(cancellationToken);
                return allBirdsFromMockDatabase;
            }

        }
    }
}
