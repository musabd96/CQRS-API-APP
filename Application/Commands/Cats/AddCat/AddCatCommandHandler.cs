using Application.Commands.Dogs;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Cats
{
    public class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly AppDbContext _dbContext;

        public AddCatCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.NewCat.Name) || request.NewCat.Name == "string")
            {
                return Task.FromResult<Cat>(null!);
            }

            Cat catToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewCat.Name,
                LikesToPlay = request.NewCat.LikesToPlay
            };

            _dbContext.Cats.Add(catToCreate);
            _dbContext.SaveChangesAsync();

            return Task.FromResult(catToCreate);
        }
    }
}
