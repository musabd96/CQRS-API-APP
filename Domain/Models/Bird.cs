using Domain.Models.Animal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Bird : AnimalModel
    {
        public new Guid Id { get; set; } = Guid.Empty;
        public new string Name { get; set; } = string.Empty;
        public override string TypeOfAnimal => "Bird";
        public override string animalCanDo => "This animal can fly";
        public bool LikesToPlay { get; set; }
        public override string Color { get; set; } = string.Empty;

        [NotMapped, JsonIgnore]
        public override string Breed { get; set; } = string.Empty;

        [NotMapped, JsonIgnore]
        public override int Weight { get; set; }
    }
}
