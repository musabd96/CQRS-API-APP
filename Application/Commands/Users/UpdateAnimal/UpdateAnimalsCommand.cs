using Application.Dtos.Animals;
using Domain.Models.Animal;
using MediatR;

namespace Application.Commands.Users.UpdateAnimal
{
    public class UpdateAnimalsCommand : IRequest<AnimalModel>
    {
        public UpdateAnimalsCommand(Guid id, AnimalDto updatedanimal, string username)
        {
            Id = id;
            UpdatedAnimal = updatedanimal;
            UserName = username;
        }
        public Guid Id { get; }
        public AnimalDto UpdatedAnimal { get; }
        public string UserName { get; }

    }
}
