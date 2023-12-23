using Domain.Models.Animal;
using MediatR;
using Infrastructure.Repositories.Users;

namespace Application.Commands.Users.UpdateAnimal
{
    public sealed class UpdateAnimalsCommandHandler : IRequestHandler<UpdateAnimalsCommand, AnimalModel>
    {
        private readonly IUserRepository _userRepository;

        public UpdateAnimalsCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<AnimalModel> Handle(UpdateAnimalsCommand request, CancellationToken cancellationToken)
        {
            var userName = request.UserName;
            var Id = request.Id;
            var Name = request.UpdatedAnimal.Name;
            var LikesToPlay = request.UpdatedAnimal.LikesToPlay;
            var Breed = request.UpdatedAnimal.Breed;
            var Weight = request.UpdatedAnimal.Weight;
            var Color = request.UpdatedAnimal.Color;


            AnimalModel updatedAnimals = await _userRepository.UpdateAnimal(userName, Id, Name,
                                                                            LikesToPlay, Breed, Weight,
                                                                            Color, cancellationToken);

            return updatedAnimals;
        }
    }
}
