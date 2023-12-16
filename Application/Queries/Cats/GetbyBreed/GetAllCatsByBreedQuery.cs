
using Domain.Models;
using MediatR;

namespace Application.Queries.Cats.GetbyBreed
{
    public class GetAllCatsByBreedQuery : IRequest<List<Cat>>
    {
        public GetAllCatsByBreedQuery(string Breed)
        {
            breed = Breed;
        }

        public string breed { get; }
    }
}
