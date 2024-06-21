using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UITEventAPI.Application.Domain.Users;

namespace UITEventAPI.Application.Infrastructure.Data.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id)
            .HasName($"{nameof(User)}Id");

        builder.Property(u => u.AvatarUrl)
            .HasColumnType("varchar(max)");
    }
}
