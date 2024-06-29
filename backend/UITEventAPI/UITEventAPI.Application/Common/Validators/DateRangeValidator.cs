using FluentValidation;
using UITEventAPI.Application.Common.Constants;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Common.Validators;

public class DateRangeValidator : AbstractValidator<DateRange>
{
    public DateRangeValidator()
    {
        RuleFor(x => x.Start)
            .LessThanOrEqualTo(x => x.End)
            .WithMessage(ValidationMessages.StartDateMustBeBeforeEndDate);

        RuleFor(x => x.End)
            .GreaterThanOrEqualTo(x => x.Start)
            .WithMessage(ValidationMessages.StartDateMustBeBeforeEndDate);
    }
}
