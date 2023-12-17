using System.Text.Json.Serialization;

namespace Application.Dtos.AnimalDto
{
    public class BirdDto
    {
        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public bool LikesToPlay { get; set; }
        public string OwnerBirdUserName { get; set; } = string.Empty;

        [JsonIgnore]
        public ICollection<Guid> BirdOwnerIds { get; set; } = new List<Guid>();
    }
}
