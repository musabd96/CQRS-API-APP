
using Domain.Models;
using MediatR;

namespace Application.Queries.Cats.GetbyBreed
{
    public class GetAllCatsByCriteriaQuery : IRequest<List<Cat>>
    {
        public GetAllCatsByCriteriaQuery(string Breed, int? Weight)
        {
            breed = Breed;
            weight = Weight;
        }

        public string breed { get; }
        public int? weight { get; }
    }
}
