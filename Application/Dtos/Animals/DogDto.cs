﻿

using System.Text.Json.Serialization;

namespace Application.Dtos.AnimalDto
{
    public class DogDto
    {
        public string Name { get; set; } = string.Empty;
        public bool LikesToPlay { get; set; }
        public string Breed { get; set; } = string.Empty;
        public int Weight { get; set; }
        public string OwnerDogUserName { get; set; } = string.Empty;
        [JsonIgnore]
        public virtual ICollection<Guid> DogOwnerIds { get; set; } = new List<Guid>();
    }
}
