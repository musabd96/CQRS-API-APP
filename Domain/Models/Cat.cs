using Domain.Models.Animal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models
{
    public class Cat : AnimalModel
    {
        public new Guid Id { get; set; } = Guid.Empty;
        public new string Name { get; set; } = string.Empty;
        public override string TypeOfAnimal => "Cat";
        public override string animalCanDo => "This animal can meows";
        public bool LikesToPlay { get; set; }
        public override string Breed { get; set; } = string.Empty;
        public override int Weight { get; set; }
        [NotMapped]
        public string OwnerCatUserName { get; set; } = string.Empty;
        [NotMapped, JsonIgnore]
        public override string Color { get; set; } = string.Empty;
        [JsonIgnore]
        public virtual ICollection<UserCat> UserCat { get; set; } = new List<UserCat>();
    }
}
