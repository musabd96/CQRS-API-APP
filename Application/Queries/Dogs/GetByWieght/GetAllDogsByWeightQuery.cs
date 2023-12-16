using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Dogs.GetByWieght
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
