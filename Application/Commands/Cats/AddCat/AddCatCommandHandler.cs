using Application.Commands.Dogs;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Cats
{
    public class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly MockDatabase _mockDatabase;

        public AddCatCommandHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.NewCat.Name))
            {
                return Task.FromResult<Cat>(null);
            }

            Cat catToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewCat.Name
            };

            _mockDatabase.Cats.Add(catToCreate);

            return Task.FromResult(catToCreate);
        }
    }
}
