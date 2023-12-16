using Application.Dtos.AnimalDto;
using Domain.Models;
using MediatR;

namespace Application.Commands.Birds.UpdateBird
{
    public class UpdateBirdByIdCommand : IRequest<Bird>
    {
        public UpdateBirdByIdCommand(Guid id, BirdDto updatedBird)
        {
            Id = id;
            UpdatedBird = updatedBird;
        }

        public Guid Id { get; }
        public BirdDto UpdatedBird { get; }
    }
}
