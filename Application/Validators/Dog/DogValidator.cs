using Application.Dtos.AnimalDto;
using FluentValidation;

namespace Application.Validators.Dog
{
    public class DogValidator : AbstractValidator<DogDto>
    {
        public DogValidator()
        {
            RuleFor(dog => dog.Name)
                .NotEmpty().WithMessage("Dog Name can not be empty BROSKI")
                .NotNull().WithMessage("Dog Name can not be NULL");
        }
    }
}
