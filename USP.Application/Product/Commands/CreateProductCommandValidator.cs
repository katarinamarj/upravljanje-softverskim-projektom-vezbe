using FluentValidation;
using USP.Domain.Enums;
using USP.Domain.Extenstions;

namespace USP.Application.Product.Commands;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Product).NotNull();
        RuleFor(x => x.Product.Name).MinimumLength(3).NotEmpty();
        RuleFor(x => x.Product.Name).MaximumLength(15).NotEmpty();
        RuleFor(x => x.Product.Description).MinimumLength(15).NotEmpty();
        RuleFor(x => x.Product.Description).MaximumLength(150).NotEmpty();
        RuleFor(x => x.Product.Price).GreaterThan(0m).NotEmpty();
        RuleFor(x => x.Product.Price).LessThan(50000m).NotEmpty();
        RuleFor(x => x.Product.Category).NotNull();
        
        
        RuleFor(x => x.Product.Category).Must(t=> Category.TryFromValue(t, out _))
            .WithName("ReportType")    .WithMessage($"Category must be in list of : {EnumExtenstions.ValidCategoryList}");

    }
}