using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;

namespace UITEventAPI.Application.Infrastructure.Data.Interceptors;

internal class AuditInterceptor(
    ICurrentUserService currentUserService,
    IDateTimeService dateTimeService
) : ISaveChangesInterceptor
{
    private const int DEFAULT_USER_ID = 1;
    private readonly int userId = currentUserService.Id ?? DEFAULT_USER_ID;

    public ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        foreach (var entry in eventData.Context!.ChangeTracker.Entries<AuditableEntity>())
        {
            var now = dateTimeService.Now;
            var auditableEntity = entry.Entity;

            switch (entry.State)
            {
                case EntityState.Added:
                    auditableEntity.CreatedByUserId = userId;
                    auditableEntity.CreatedDate = now;
                    break;
                case EntityState.Modified:
                    auditableEntity.LastModifiedByUserId = userId;
                    auditableEntity.LastModifiedDate = now;
                    break;
            }

        }

        return new ValueTask<InterceptionResult<int>>(result);
    }

    public InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        // This method can be left empty if you only intend to use async saving changes.
        return result;
    }
}
