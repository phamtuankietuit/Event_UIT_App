using FluentValidation;
using UITEventAPI.Application.Common.Constants;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Common.Validators;

public class PagingOptionsValidator : AbstractValidator<PagingOptions>
{
    public PagingOptionsValidator()
    {
        RuleFor(x => x.PageSize)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.PageSizeMustBeGreaterThanZero);

        RuleFor(x => x.PageNumber)
            .GreaterThan(0)
            .WithMessage(ValidationMessages.PageNumberMustBeGreaterThanZero);
    }
}
