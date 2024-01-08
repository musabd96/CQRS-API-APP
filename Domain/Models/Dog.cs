using Domain.Models.Animal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Dog : AnimalModel
    {
        public override Guid Id { get; set; } = Guid.Empty;
        public override string Name { get; set; } = string.Empty;
        public override string TypeOfAnimal { get; set; } = string.Empty;
        public override string animalCanDo { get; set; } = string.Empty;
        public bool LikesToPlay { get; set; }
        public override string Breed { get; set; } = string.Empty;
        public override int Weight { get; set; }

        [NotMapped]
        public override string OwnerUserName { get; set; } = string.Empty;

        [NotMapped, JsonIgnore]
        public override string Color { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual ICollection<UserDog> UserDog { get; set; } = new List<UserDog>();
    }
}
