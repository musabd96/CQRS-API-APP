using Domain.Models;
using Infrastructure.Repositories.Cats;
using MediatR;

namespace Application.Commands.Cats
{
    public class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly ICatRepository _catRepository;

        public AddCatCommandHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        public Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            Cat catToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewCat.Name,
                LikesToPlay = request.NewCat.LikesToPlay,
                Breed = request.NewCat.Breed,
            };

            _catRepository.AddCat(catToCreate, cancellationToken);

            return Task.FromResult(catToCreate);
        }
    }
}
