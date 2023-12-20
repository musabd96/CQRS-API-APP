using Domain.Models.Animal;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
