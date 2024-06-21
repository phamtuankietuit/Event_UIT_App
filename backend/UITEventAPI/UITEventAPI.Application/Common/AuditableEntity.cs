using UITEventAPI.Application.Domain.Users;

namespace UITEventAPI.Application.Common;

public abstract class AuditableEntity
{
    public DateTime CreatedDate { get; set; }
    public int? CreatedByUserId { get; set; }
    public User? CreatedByUser { get; set; }

    public DateTime? LastModifiedDate { get; set; }
    public int? LastModifiedByUserId { get; set; }
    public User? LastModifiedByUser { get; set; }
}
