using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Domain.UniversityUnits;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class UniversityUnitConfiguration : IEntityTypeConfiguration<UniversityUnit>
{
    public void Configure(EntityTypeBuilder<UniversityUnit> builder)
    {
        builder.ToTable($"{nameof(UniversityUnit)}s");

        builder.Property(u => u.Id)
            .HasColumnName($"{nameof(UniversityUnit)}Id");

        builder.Property(u => u.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(u => u.Description)
            .HasColumnType("nvarchar(max)");

        builder.Property(u => u.FacebookUrl)
            .HasColumnType("varchar(max)");

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
