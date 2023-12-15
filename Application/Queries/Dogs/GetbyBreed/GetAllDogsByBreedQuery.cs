using Application.Dtos.AnimalDto;
using Domain.Models;
using MediatR;

namespace Application.Queries.Dogs.GetbyBreed
{
    public class GetAllDogsByBreedQuery : IRequest<List<Dog>>
    {
        public GetAllDogsByBreedQuery(string Breed)
        {
            breed = Breed;
        }

        public string breed { get; }
    }
}
