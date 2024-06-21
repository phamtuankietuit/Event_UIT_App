using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Domain.UniversityUnit;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class UniversityUnitConfiguration : IEntityTypeConfiguration<UniversityUnit>
{
    public void Configure(EntityTypeBuilder<UniversityUnit> builder)
    {
        builder.ToTable($"{nameof(UniversityUnit)}s");

        builder.HasKey(u => u.Id)
            .HasName($"{nameof(UniversityUnit)}Id");

        builder.Property(u => u.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasOne(u => u.User)
            .WithOne()
            .HasForeignKey<UniversityUnit>(u => u.UserId);

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
