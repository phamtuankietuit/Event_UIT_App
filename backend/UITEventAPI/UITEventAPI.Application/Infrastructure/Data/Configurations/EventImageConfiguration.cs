using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Domain.Events;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class EventImageConfiguration : IEntityTypeConfiguration<EventImage>
{
    public void Configure(EntityTypeBuilder<EventImage> builder)
    {
        builder.ToTable($"{nameof(EventImage)}s");

        builder.HasKey(ei => ei.Id)
            .HasName($"{nameof(EventImage)}Id");

        builder.Property(ei => ei.ImageUrl)
            .HasColumnType("varchar(max)")
            .IsRequired();


        // relationships
        builder.HasOne(ei => ei.Event)
            .WithMany(e => e.Images)
            .HasForeignKey(ei => ei.EventId);
    }
}
