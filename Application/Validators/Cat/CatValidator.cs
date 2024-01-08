using Application.Dtos.AnimalDto;
using FluentValidation;

namespace Application.Validators.Cat
{
    public class CatValidator : AbstractValidator<CatDto>
    {
        public CatValidator()
        {
            RuleFor(cat => cat.Name)
                .NotEmpty().WithMessage("Cat Name can not be empty")
                .NotNull().WithMessage("Cat Name can not be NULL")
                .NotEqual("string", StringComparer.OrdinalIgnoreCase);
        }
    }
}
