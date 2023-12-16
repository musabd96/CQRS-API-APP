using Domain.Models;
using MediatR;

namespace Application.Queries.Dogs.GetByWeight
{
    public class GetAllDogsByWeightQuery : IRequest<List<Dog>>
    {
        public GetAllDogsByWeightQuery(int Weight)
        {
            weight = Weight;
        }
        public int weight { get; }
    }
}
