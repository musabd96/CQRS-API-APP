using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Birds.GetById
{
    public class GetBirdByIdQueryHandler : IRequestHandler<GetBirdByIdQuery, Bird>
    {
        private readonly AppDbContext _dbContext;

        public GetBirdByIdQueryHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Bird> Handle(GetBirdByIdQuery request, CancellationToken cancellationToken)
        {
            Bird wantedBird = _dbContext.Birds.FirstOrDefault(bird => bird.Id == request.Id)!;

            if (wantedBird == null)
            {
                // Return null if the bird is not found
                return Task.FromResult<Bird>(null);
            }

            return Task.FromResult(wantedBird);
        }


    }
}
