using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Cats.UpdateCat
{
    public class UpdateCatByIdCommandHandler : IRequestHandler<UpdateCatByIdCommand, Cat>
    {
        private readonly AppDbContext _dbContext;

        public UpdateCatByIdCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Cat> Handle(UpdateCatByIdCommand request, CancellationToken cancellationToken)
        {
            Cat catToUpdate = _dbContext.Cats.FirstOrDefault(cat => cat.Id == request.Id)!;

            if (catToUpdate != null)
            {
                if (string.IsNullOrEmpty(catToUpdate.Name) || request.UpdatedCat.Name == "string")
                {
                    return Task.FromResult<Cat>(null!);
                }
                else
                {
                    catToUpdate.Name = request.UpdatedCat.Name;
                    catToUpdate.LikesToPlay = request.UpdatedCat.LikesToPlay;

                    _dbContext.SaveChangesAsync();

                    return Task.FromResult(catToUpdate);
                }

            }

            return Task.FromResult(catToUpdate)!;
        }
    }
}
