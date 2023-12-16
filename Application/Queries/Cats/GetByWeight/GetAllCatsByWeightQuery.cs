using Domain.Models;
using MediatR;

namespace Application.Queries.Cats.GetByWeight
{
    public class GetAllCatsByWeightQuery : IRequest<List<Cat>>
    {
        public GetAllCatsByWeightQuery(int Weight)
        {
            weight = Weight;
        }

        public int weight { get; }
    }
}
