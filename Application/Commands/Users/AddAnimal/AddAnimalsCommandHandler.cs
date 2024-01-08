
using Application.Queries.Users.GetAll;
using Domain.Models.Animal;
using Infrastructure.Repositories.Users;
using MediatR;

namespace Application.Commands.Users.AddAnimal
{
    public sealed class AddAnimalsCommandHandler : IRequestHandler<AddAnimalsCommand, List<AnimalModel>>
    {
        private readonly IUserRepository _userRepository;

        public AddAnimalsCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<List<AnimalModel>> Handle(AddAnimalsCommand request, CancellationToken cancellationToken)
        {
            AnimalModel animalToAdd = new AnimalModel()
            {
                Id = Guid.NewGuid(),
                Name = request.newAnimal.Name,
                TypeOfAnimal = request.newAnimal.TypeOfAnimal,
                LikesToPlay = request.newAnimal.LikesToPlay,
                animalCanDo = request.newAnimal.animalCanDo,
                Breed = request.newAnimal.Breed,
                Weight = request.newAnimal.Weight,
                Color = request.newAnimal.Color
            };

            _userRepository.AddAnimal(request.userName, animalToAdd, cancellationToken);

            // Return the newly created animal
            return Task.FromResult(new List<AnimalModel> { animalToAdd });
        }

    }
}
