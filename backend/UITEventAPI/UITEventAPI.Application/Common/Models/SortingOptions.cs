namespace UITEventAPI.Application.Common.Models;

public class SortingOptions
{
    public const string DEFAULT_SORT_PROPERTY = "CreatedDate";
    public string SortBy { get; set; } = DEFAULT_SORT_PROPERTY;
    public bool SortAscending { get; set; } = false;
}
