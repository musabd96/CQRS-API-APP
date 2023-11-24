using Domain.Models.Animal;

namespace Domain.Models
{
    public class Dog : AnimalModel
    {
        public override string TypeOfAnimal => "Dog";
        public override string animalCanDo => "This animal can bark";
    }
}
