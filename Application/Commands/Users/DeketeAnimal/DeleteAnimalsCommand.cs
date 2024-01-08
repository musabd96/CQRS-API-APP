using Domain.Models.Animal;
using MediatR;

namespace Application.Commands.Users.DeketeAnimal
{
    public class DeleteAnimalsCommand : IRequest<AnimalModel>
    {
        public DeleteAnimalsCommand(Guid animalId, string username)
        {
            Id = animalId;
            UserName = username;
        }
        public Guid Id { get; }
        public string UserName { get; }

    }
}
