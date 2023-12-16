﻿using Domain.Models;
using Infrastructure.Repositories.Cats;
using MediatR;

namespace Application.Queries.Cats.GetByWeight
{
    public sealed class GetAllCatsByWeightQueryHandler : IRequestHandler<GetAllCatsByWeightQuery, List<Cat>>
    {
        private readonly ICatRepository _catRepository;

        public GetAllCatsByWeightQueryHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        public async Task<List<Cat>> Handle(GetAllCatsByWeightQuery request, CancellationToken cancellationToken)
        {
            List<Cat> cats = await _catRepository.GetAllCatsByWeight(request.weight, cancellationToken);

            return cats;
        }
    }
}