using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Infrastructure.Identity;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder.Property(rt => rt.Id)
            .HasColumnName($"{nameof(RefreshToken)}Id");

        builder.Property(rt => rt.Token)
            .HasMaxLength(500)
            .IsRequired();

        builder.Property(rt => rt.ExpiryDate)
            .IsRequired();

        builder.Property(rt => rt.CreatedDate)
            .IsRequired();
    }
}
