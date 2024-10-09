using FluentValidation;
using USP.Application.Common.Dto;
using USP.Application.Product.Commands;
using USP.Domain.Enums;
using USP.Domain.Extensions;

namespace USP.Application.Common.Validators;

public class EditUserDtoValidator : AbstractValidator<EditUserDto>
{
   public EditUserDtoValidator()
   {
      RuleFor(x => x.FirstName).MinimumLength(3).NotEmpty();
      RuleFor(x => x.FirstName).MaximumLength(15).NotEmpty();
      RuleFor(x => x.Lastname).MinimumLength(3).NotEmpty();
      RuleFor(x => x.Lastname).MaximumLength(15).NotEmpty();
      RuleFor(x => x.Email).MinimumLength(3).NotEmpty();
      RuleFor(x => x.Email).MaximumLength(150).NotEmpty();
        
        
         

   }
}