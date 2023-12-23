using Domain.Models.Animal;
using Infrastructure.Repositories.Users;
using MediatR;

namespace Application.Commands.Users.DeketeAnimal
{
    public sealed class DeleteAnimalsCommandHandler : IRequestHandler<DeleteAnimalsCommand, AnimalModel>
    {
        private readonly IUserRepository _userRepository;

        public DeleteAnimalsCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<AnimalModel> Handle(DeleteAnimalsCommand request, CancellationToken cancellationToken)
        {
            AnimalModel updatedAnimals = await _userRepository.DeleteAnimal(request.Id, request.UserName, cancellationToken);

            return updatedAnimals;
        }
    }
}
