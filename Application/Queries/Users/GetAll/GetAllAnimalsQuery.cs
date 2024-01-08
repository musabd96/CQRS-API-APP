using Domain.Models.Animal;
using MediatR;

namespace Application.Queries.Users.GetAll
{
    public class GetAllAnimalsQuery : IRequest<List<AnimalModel>>
    {
        public GetAllAnimalsQuery(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }
    }
}
