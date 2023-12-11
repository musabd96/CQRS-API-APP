using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Cats.DeleteCat
{
    public class DeleteCatByIdCommandHandler : IRequestHandler<DeleteCatByIdCommand, Cat>
    {
        private readonly AppDbContext _dbContext;

        public DeleteCatByIdCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Cat> Handle(DeleteCatByIdCommand request, CancellationToken cancellationToken)
        {
            var catToDelete = _dbContext.Cats.FirstOrDefault(cat => cat.Id == request.Id);

            if (catToDelete != null)
            {
                _dbContext.Cats.Remove(catToDelete);
                _dbContext.SaveChangesAsync();
                return Task.FromResult(catToDelete);
            }

            // Cat not found
            return Task.FromResult(catToDelete);
        }
    }
}
