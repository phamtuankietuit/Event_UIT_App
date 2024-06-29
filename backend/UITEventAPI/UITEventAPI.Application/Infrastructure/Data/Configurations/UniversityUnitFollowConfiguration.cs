using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Domain.UniversityUnits;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class UniversityUnitFollowConfiguration : IEntityTypeConfiguration<UnitFollow>
{
    public void Configure(EntityTypeBuilder<UnitFollow> builder)
    {
        builder.ToTable($"{nameof(UnitFollow)}s");
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasColumnName($"{nameof(UnitFollow)}Id")
            .ValueGeneratedOnAdd();

        builder.Property(e => e.StudentId)
            .IsRequired();

        builder.Property(e => e.UniversityUnitId)
            .IsRequired();

        builder.HasOne(e => e.Student)
            .WithMany(s => s.FollowedUnits)
            .HasForeignKey(e => e.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(e => e.UniversityUnit)
            .WithMany(u => u.FollowedStudents)
            .HasForeignKey(e => e.UniversityUnitId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
