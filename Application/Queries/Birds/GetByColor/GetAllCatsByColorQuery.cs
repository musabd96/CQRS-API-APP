using Domain.Models;
using MediatR;

namespace Application.Queries.Birds.GetByColor
{
    public class GetAllCatsByColorQuery : IRequest<List<Bird>>
    {
        public GetAllCatsByColorQuery(string Color)
        {
            color = Color;
        }

        public string color { get; }
    }
}
