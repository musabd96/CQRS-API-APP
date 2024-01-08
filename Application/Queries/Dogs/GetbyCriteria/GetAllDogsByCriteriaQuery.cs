using Application.Dtos.AnimalDto;
using Domain.Models;
using MediatR;

namespace Application.Queries.Dogs.GetbyBreed
{
    public class GetAllDogsByCriteriaQuery : IRequest<List<Dog>>
    {
        public GetAllDogsByCriteriaQuery(string Breed, int? Weight)
        {
            breed = Breed;
            weight = Weight;
        }

        public string breed { get; }
        public int? weight { get; }
    }
}
