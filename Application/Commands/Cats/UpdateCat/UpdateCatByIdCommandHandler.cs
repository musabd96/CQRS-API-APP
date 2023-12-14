﻿using Domain.Models;
using Infrastructure.Database;
using Infrastructure.Repositories.Cats;
using MediatR;

namespace Application.Commands.Cats.UpdateCat
{
    public class UpdateCatByIdCommandHandler : IRequestHandler<UpdateCatByIdCommand, Cat>
    {
        private readonly ICatRepository _catRepository;

        public UpdateCatByIdCommandHandler(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }

        public async Task<Cat> Handle(UpdateCatByIdCommand request, CancellationToken cancellationToken)
        {
            var Id = request.Id;
            var Name = request.UpdatedCat.Name;
            var LikesToPlay = request.UpdatedCat.LikesToPlay;
            var Breed = request.UpdatedCat.Breed;

            Cat catToUpdate = await _catRepository.UpdateCat(Id, Name, LikesToPlay, Breed, cancellationToken);

            return catToUpdate;
        }
    }
}
