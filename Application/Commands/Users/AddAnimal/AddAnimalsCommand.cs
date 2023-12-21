
using Application.Dtos.AnimalDto;
using Application.Dtos.Animals;
using Domain.Models.Animal;
using MediatR;

namespace Application.Commands.Users.AddAnimal
{
    public class AddAnimalsCommand : IRequest<List<AnimalModel>>
    {
        public AddAnimalsCommand(string UserName, AnimalDto NewAnimal)
        {
            newAnimal = NewAnimal;
            userName = UserName;

        }
        public AnimalDto newAnimal { get; }
        public string userName { get; set; }
    }
}
