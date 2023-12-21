using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Animals
{
    public class AnimalDto
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string TypeOfAnimal { get; set; } = string.Empty;
        public virtual string animalCanDo { get; set; } = string.Empty;
        public virtual bool LikesToPlay { get; set; }
        public virtual string Color { get; set; } = string.Empty;
        public virtual string Breed { get; set; } = string.Empty;
        public virtual int Weight { get; set; }
        public virtual string OwnerUserName { get; set; } = string.Empty;
    }
}
