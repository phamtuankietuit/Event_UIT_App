using UITEventAPI.Application.Domain.Users;

namespace UITEventAPI.Application.Domain.UniversityUnit;

public class UnitFollow
{
    public int Id { get; set; }
    public int UniversityUnitId { get; set; }
    public UniversityUnit UniversityUnit { get; set; } = null!;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public bool IsFollowed { get; set; }
    public DateTime FollowedDate { get; set; }
}
