using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserDog
    {
        public Guid DogId { get; set; }
        public Dog Dog { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
