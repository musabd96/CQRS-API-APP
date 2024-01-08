using Domain.Models;
using Domain.Models.Animal;
using Infrastructure.Repositories.Users;
using MediatR;

namespace Application.Queries.Users.GetAll
{
    public sealed class GetAllAnimalsQueryHandler : IRequestHandler<GetAllAnimalsQuery, List<AnimalModel>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllAnimalsQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<List<AnimalModel>> Handle(GetAllAnimalsQuery request, CancellationToken cancellationToken)
        {
            List<AnimalModel> allAnimals = Task.Run(() => _userRepository.GetAllAnimals(request.UserName, cancellationToken)).Result;

            return Task.FromResult(allAnimals);
        }
    }
}
