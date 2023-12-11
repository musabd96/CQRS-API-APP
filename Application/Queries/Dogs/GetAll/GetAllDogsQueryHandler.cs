using Application.Queries.Dogs.GetAll;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Dogs
{
    public sealed class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly AppDbContext _dbContext;

        public GetAllDogsQueryHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Dog> allDogsFromMockDatabase = _dbContext.Dogs.ToList();
            return Task.FromResult(allDogsFromMockDatabase);
        }

    }
}
