using Domain.Models;
using Infrastructure.Repositories.Dogs;
using MediatR;

namespace Application.Queries.Dogs.GetById
{
    public class GetDogByIdQueryHandler : IRequestHandler<GetDogByIdQuery, Dog>
    {
        private readonly IDogRepository _dogRepository;

        public GetDogByIdQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public Task<Dog> Handle(GetDogByIdQuery request, CancellationToken cancellationToken)
        {
            Dog wantedDog = Task.Run(() => _dogRepository.GetDogById(request.Id, cancellationToken)).Result;

            return Task.FromResult(wantedDog);
        }
    }
}
