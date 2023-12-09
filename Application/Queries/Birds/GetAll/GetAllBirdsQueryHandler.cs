using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries.Birds.GetAll
{
    public class GetAllBirdsQueryHandler : IRequestHandler<GetAllBirdsQuery, List<Bird>>
    {
        private readonly AppDbContext _dbContext;

        public GetAllBirdsQueryHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Bird>> Handle(GetAllBirdsQuery request, CancellationToken cancellationToken)
        {
            List<Bird> allBirdsFromMockDatabase = await _dbContext.Birds
                .ToListAsync(cancellationToken);


            if (allBirdsFromMockDatabase == null || !allBirdsFromMockDatabase.Any())
            {
                // Throw an exception if the list is empty
                throw new InvalidOperationException("No birds found");
            }
            else
            {
                return allBirdsFromMockDatabase;
            }
        }


    }
}
