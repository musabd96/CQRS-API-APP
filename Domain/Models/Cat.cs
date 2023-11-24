using Domain.Models.Animal;

namespace Domain.Models
{
    public class Cat : AnimalModel
    {
        public string Meow()
        {
            return "This animal meows";
        }
    }
}
