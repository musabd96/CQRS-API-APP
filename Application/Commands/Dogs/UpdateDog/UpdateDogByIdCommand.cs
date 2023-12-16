using Application.Dtos.AnimalDto;
using Domain.Models;
using MediatR;

namespace Application.Commands.Dogs.UpdateDog
{
    public class UpdateDogByIdCommand : IRequest<Dog>
    {
        public UpdateDogByIdCommand(Guid id, DogDto updatedDog)
        {
            Id = id;
            UpdatedDog = updatedDog;
        }

        public DogDto UpdatedDog { get; }
        public Guid Id { get; }
    }
}