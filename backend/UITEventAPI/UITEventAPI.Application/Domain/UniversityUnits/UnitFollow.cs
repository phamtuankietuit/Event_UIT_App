using UITEventAPI.Application.Domain.Students;
using UITEventAPI.Application.Domain.Users;

namespace UITEventAPI.Application.Domain.UniversityUnits;

public class UnitFollow
{
    public int Id { get; set; }
    public int UniversityUnitId { get; set; }
    public UniversityUnit UniversityUnit { get; set; } = null!;

    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;

    public bool IsFollowed { get; set; }
    public DateTime? FollowedDate { get; set; }
}
