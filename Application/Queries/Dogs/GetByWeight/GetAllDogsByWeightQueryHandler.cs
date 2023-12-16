using Application.Queries.Dogs.GetbyBreed;
using Domain.Models;
using Infrastructure.Repositories.Dogs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Dogs.GetByWeight
{
    public sealed class GetAllDogsByWeightQueryHandler : IRequestHandler<GetAllDogsByWeightQuery, List<Dog>>
    {
        private readonly IDogRepository _dogRepository;

        public GetAllDogsByWeightQueryHandler(IDogRepository dogRepository)
        {
            _dogRepository = dogRepository;
        }

        public async Task<List<Dog>> Handle(GetAllDogsByWeightQuery request, CancellationToken cancellationToken)
        {
            List<Dog> dogs = await _dogRepository.GetAllDogsByWeight(request.weight, cancellationToken);

            return dogs;
        }
    }
}
