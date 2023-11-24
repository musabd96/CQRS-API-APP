using Domain.Models.Animal;

namespace Domain.Models
{
    public class Cat : AnimalModel
    {
        public override string TypeOfAnimal => "Cat";
        public override string animalCanDo => "This animal can meows";
    }
}
