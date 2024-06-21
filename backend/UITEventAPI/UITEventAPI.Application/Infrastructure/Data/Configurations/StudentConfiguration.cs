using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Domain.Students;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable($"{nameof(Student)}s");

        builder.HasKey(s => s.Id)
            .HasName($"{nameof(Student)}Id");

        builder.Property(s => s.StudentCode)
            .IsRequired();

        builder.Property(u => u.FirstName)
            .HasColumnType("nvarchar(300)")
            .IsRequired();

        builder.Property(u => u.LastName)
            .HasColumnType("nvarchar(300)")
            .IsRequired();

        builder.HasIndex(u => u.StudentCode)
            .IsUnique();

        // relationships
        builder.HasOne(s => s.User)
            .WithOne()
            .HasForeignKey<Student>(s => s.UserId);

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
