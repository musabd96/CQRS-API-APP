using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Cats.GetById
{
    public class GetCatByIdQueryHandler : IRequestHandler<GetCatByIdQuery, Cat>
    {
        private readonly AppDbContext _dbContext;

        public GetCatByIdQueryHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Cat> Handle(GetCatByIdQuery request, CancellationToken cancellationToken)
        {
            Cat wantedCat = _dbContext.Cats.FirstOrDefault(Cat => Cat.Id == request.Id)!;

            if (wantedCat == null)
            {
                // Return null if the cat is not found
                return Task.FromResult<Cat>(null!);
            }
            return Task.FromResult(wantedCat);
        }
    }
}
