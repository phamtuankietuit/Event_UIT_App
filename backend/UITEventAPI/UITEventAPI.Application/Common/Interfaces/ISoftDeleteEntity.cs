namespace UITEventAPI.Application.Common.Interfaces;

public interface ISoftDeleteEntity
{
    bool IsDeleted { get; set; }
    DateTime DeletedDate { get; set; }
}
