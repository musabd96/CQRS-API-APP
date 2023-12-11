

using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogByIdCommandHandler : IRequestHandler<DeleteDogByIdCommand, Dog>
    {
        private readonly AppDbContext _dbContext;

        public DeleteDogByIdCommandHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Dog> Handle(DeleteDogByIdCommand request, CancellationToken cancellationToken)
        {
            var dogToDelete = _dbContext.Dogs.FirstOrDefault(d => d.Id == request.Id);

            if (dogToDelete != null)
            {
                _dbContext.Dogs.Remove(dogToDelete);
                _dbContext.SaveChangesAsync();
                return Task.FromResult(dogToDelete);
            }

            // Dog not found
            return Task.FromResult<Dog>(dogToDelete!);
        }
    }
}
