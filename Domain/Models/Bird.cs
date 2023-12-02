using Domain.Models.Animal;

namespace Domain.Models
{
    public class Bird : AnimalModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public override string TypeOfAnimal => "Bird";
        public override string animalCanDo => "This animal can fly";
        public bool LikesToPlay { get; set; }
    }
}
