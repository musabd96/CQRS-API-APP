using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Dogs.GetById
{
    public class GetDogByIdQueryHandler : IRequestHandler<GetDogByIdQuery, Dog>
    {
        private readonly AppDbContext _dbContext;

        public GetDogByIdQueryHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Dog> Handle(GetDogByIdQuery request, CancellationToken cancellationToken)
        {
            Dog wantedDog = _dbContext.Dogs.FirstOrDefault(dog => dog.Id == request.Id)!;
            if (wantedDog == null)
            {
                // Return null if the bird is not found
                return Task.FromResult<Dog>(null!);
            }
            return Task.FromResult(wantedDog);
        }
    }
}
