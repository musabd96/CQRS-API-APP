namespace Domain.Models.Animal
{
    public class AnimalModel
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
