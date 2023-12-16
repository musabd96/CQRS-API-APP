using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual ICollection<UserBird> UserBird { get; set; }
        public virtual ICollection<UserCat> UserCat { get; set; }
        public virtual ICollection<UserDog> UserDog { get; set; }
    }
}
