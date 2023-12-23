using Domain.Models.Animal;
using MediatR;

namespace Application.Queries.Users.GetById
{
    public class GetAnimalByIdQuery : IRequest<AnimalModel>
    {
        public GetAnimalByIdQuery(Guid id, string userName)
        {
            Id = id;
            UserName = userName;
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
    }
}
