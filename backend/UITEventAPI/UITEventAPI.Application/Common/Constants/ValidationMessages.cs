namespace UITEventAPI.Application.Common.Constants;

public static class ValidationMessages
{
    // Invalid
    public const string InvalidSortProperty = "Invalid sort property. Valid properties are: {0}";
    public const string InvalidEnumValue = "Invalid value for {0}. Valid values are: {1}";

    // Must be provided
    public const string SortAscendingMustBeProvided = "SortAscending property must be provided.";
    public const string SortByMustBeProvided = "SortBy property must be provided.";

    // Must be greater than 0
    public const string PageSizeMustBeGreaterThanZero = "PageSize must be greater than 0.";
    public const string PageNumberMustBeGreaterThanZero = "PageNumber must be greater than 0.";

    // Start date must be before end date
    public const string StartDateMustBeBeforeEndDate = "The start date must be before the end date.";
}
