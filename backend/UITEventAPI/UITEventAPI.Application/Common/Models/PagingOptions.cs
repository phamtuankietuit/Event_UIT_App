namespace UITEventAPI.Application.Common.Models;

public class PagingOptions
{
    public const int DEFAULT_PAGE_SIZE = 10;
    public const int DEFAULT_PAGE_NUMBER = 1;

    public int PageSize { get; set; } = DEFAULT_PAGE_SIZE;
    public int PageNumber { get; set; } = DEFAULT_PAGE_NUMBER;
}
