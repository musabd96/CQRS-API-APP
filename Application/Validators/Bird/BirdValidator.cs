using Application.Dtos.AnimalDto;
using FluentValidation;

namespace Application.Validators.Bird
{
    public class BirdValidator : AbstractValidator<BirdDto>
    {
        public BirdValidator()
        {
            RuleFor(bird => bird.Name)
                .NotEmpty().WithMessage("Bird Name can not be empty")
                .NotNull().WithMessage("Bird Name can not be NULL")
                .NotEqual("string", StringComparer.OrdinalIgnoreCase);
        }
    }
}
