using Domain.Models.Animal;

namespace Domain.Models
{
    public class Bird : AnimalModel
    {
        public override string TypeOfAnimal => "Bird";
        public override string animalCanDo => "This animal can fly";
    }
}
