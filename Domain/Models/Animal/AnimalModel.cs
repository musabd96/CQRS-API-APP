namespace Domain.Models.Animal
{
    public class AnimalModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual string TypeOfAnimal { get; } = string.Empty;
        public virtual string animalCanDo { get; } = string.Empty;
    }
}
