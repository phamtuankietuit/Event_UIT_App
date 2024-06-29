using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Domain.Events;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable($"{nameof(Event)}s");

        builder.Property(e => e.Id)
            .HasColumnName($"{nameof(Event)}Id");

        builder.Property(e => e.Title)
            .HasColumnType("nvarchar(400)");

        builder.Property(e => e.Description)
            .HasColumnType("nvarchar(max)");

        builder.Property(e => e.Location)
            .HasColumnType("nvarchar(max)");
        
        builder.Property(e => e.FormUrl)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.QRImageUrl)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.CheckinFileUrl)
            .HasColumnType("varchar(max)");

        builder.Property(e => e.Type)
            .HasConversion<string>();

        // relationships
        builder.HasOne(e => e.UniversityUnit)
            .WithMany(u => u.HostedEvents)
            .HasForeignKey(e => e.UniversityUnitId);

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
