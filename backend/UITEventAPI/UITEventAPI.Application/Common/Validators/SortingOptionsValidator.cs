using FluentValidation;
using Microsoft.AspNetCore.Components.Forms;
using UITEventAPI.Application.Common.Constants;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Common.Validators;

public class SortingOptionsValidator : AbstractValidator<SortingOptions>
{
    public SortingOptionsValidator(IEnumerable<string> validSortProperties)
    {
        RuleFor(x => x.SortBy)
            .NotEmpty()
            .WithMessage(ValidationMessages.SortByMustBeProvided);

        RuleFor(x => x.SortBy)
            .Must(x => validSortProperties.Contains(x))
            .WithMessage(string.Format(ValidationMessages.InvalidSortProperty, string.Join(", ", validSortProperties)));

        RuleFor(x => x.SortAscending)
            .NotNull()
            .WithMessage(ValidationMessages.SortAscendingMustBeProvided);
    }
}
