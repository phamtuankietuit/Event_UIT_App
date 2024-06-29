namespace UITEventAPI.Application.Common.Interfaces;

public interface IDateTimeService
{
    DateTime Now { get; }
    string NowInFileName { get; }
}
