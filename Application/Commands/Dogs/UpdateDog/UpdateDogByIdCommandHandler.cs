using Domain.Models;
using Infrastructure.Repositories.Dogs;
using MediatR;

namespace Application.Commands.Dogs.UpdateDog
{
    public class UpdateDogByIdCommandHandler : IRequestHandler<UpdateDogByIdCommand, Dog>
    {
        private readonly IDogRepository _dogRepository;

        public UpdateDogByIdCommandHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public async Task<Dog> Handle(UpdateDogByIdCommand request, CancellationToken cancellationToken)
        {
            var Id = request.Id;
            var Name = request.UpdatedDog.Name;
            var LikesToPlay = request.UpdatedDog.LikesToPlay;
            var Breed = request.UpdatedDog.Breed;

            Dog dogToUpdate = await _dogRepository.UpdateDog(Id, Name, LikesToPlay, Breed, cancellationToken);

            return dogToUpdate;
        }
    }
}
