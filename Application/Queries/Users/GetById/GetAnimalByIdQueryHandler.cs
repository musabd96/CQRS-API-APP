
using Domain.Models.Animal;
using Infrastructure.Repositories.Users;
using MediatR;

namespace Application.Queries.Users.GetById
{
    public sealed class GetAnimalByIdQueryHandler : IRequestHandler<GetAnimalByIdQuery, AnimalModel>
    {
        private readonly IUserRepository _userRepository;

        public GetAnimalByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<AnimalModel> Handle(GetAnimalByIdQuery request, CancellationToken cancellationToken)
        {
            AnimalModel allAnimals = Task.Run(() => _userRepository.GetAnimalById(request.Id, request.UserName, cancellationToken)).Result;

            return Task.FromResult(allAnimals);
        }
    }
}
