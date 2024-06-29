using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Domain.Events;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class EventRegistrationConfiguration : IEntityTypeConfiguration<EventRegistration>
{
    public void Configure(EntityTypeBuilder<EventRegistration> builder)
    {
        builder.ToTable($"{nameof(EventRegistration)}s");

        builder.Property(er => er.Id)
            .HasColumnName($"{nameof(EventRegistration)}Id");

        var AttendedDateName = nameof(EventRegistration.AttendedDate);
        var RegisterDateName = nameof(EventRegistration.RegisterDate);

        builder.ToTable(t => t.HasCheckConstraint(
            "CK_EventRegistration_AttendedDate_GreaterThan_RegistrationDate",
            $"{AttendedDateName} IS NULL OR {RegisterDateName} IS NULL OR {AttendedDateName} >= {RegisterDateName}"
        ));
        
        // relationships
        builder.HasOne(er => er.Event)
            .WithMany(e => e.Registrations)
            .HasForeignKey(er => er.EventId);

        builder.HasOne(er => er.Student)
            .WithMany(s => s.RegisteredEvents)
            .HasForeignKey(er => er.StudentId);

        builder.HasOne(u => u.CreatedByUser)
            .WithMany()
            .HasForeignKey(u => u.CreatedByUserId)
            .IsRequired(false);

        builder.HasOne(u => u.LastModifiedByUser)
            .WithMany()
            .HasForeignKey(u => u.LastModifiedByUserId)
            .IsRequired(false);
    }
}
