using Domain.Models;
using MediatR;

namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogByIdCommand : IRequest<Dog>
    {
        public DeleteDogByIdCommand(Guid dogId)
        {
            Id = dogId;
        }

        public Guid Id { get; }
    }

}
