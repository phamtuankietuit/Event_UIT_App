using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Domain.UniversityUnits;

public static class UniversityUnitErrors
{
    public static readonly Error NotFound = Error.NotFound("UniversityUnit.NotFound", "University unit not found");
    public static readonly Error AlreadyFollowed = Error.Conflict("UniversityUnit.AlreadyFollowed", "University unit is already followed by this student");
    public static readonly Error FollowFailed = Error.Conflict("UniversityUnit.FollowFailed", "Failed to follow university unit");
}
