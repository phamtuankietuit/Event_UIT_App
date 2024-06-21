using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Diagnostics;
using System.Linq.Expressions;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Students;
using UITEventAPI.Application.Domain.UniversityUnit;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data.Seeder;
using UITEventAPI.Application.Infrastructure.Identity;

namespace UITEventAPI.Application.Infrastructure.Data;

public class ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options,
    IPasswordHasher<User> passwordHasher
) : IdentityDbContext<User, IdentityRole<int>, int>(options)
{
    private readonly IPasswordHasher<User> _passwordHasher = passwordHasher;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyConfigurationsFromAssembly(typeof(RefreshToken).Assembly);

        // Restrict deletion cascade
        foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }

        // Apply global filter for soft delete entities
        builder.Model.GetEntityTypes()
            .Where(entityType => typeof(ISoftDeleteEntity).IsAssignableFrom(entityType.ClrType))
            .ToList()
            .ForEach(et =>
                builder.Entity(et.ClrType)
                    .HasQueryFilter(ConvertFilterExpression<ISoftDeleteEntity>(e => !e.IsDeleted, et.ClrType))
            );

        SetUpSeedDataWithBogus(builder);
    }

    private void SetUpSeedDataWithBogus(ModelBuilder builder)
    {
        var dataSeeder = new DataSeeder(_passwordHasher);

        builder.Entity<User>().HasData(dataSeeder.Users);
        builder.Entity<IdentityUserRole<int>>().HasData(dataSeeder.IdentityUserRoles);
        builder.Entity<Student>().HasData(dataSeeder.Students);
        builder.Entity<UniversityUnit>().HasData(dataSeeder.UniversityUnits);
        builder.Entity<Event>().HasData(dataSeeder.Events);
        builder.Entity<EventRegistration>().HasData(dataSeeder.EventRegistrations);
        builder.Entity<EventImage>().HasData(dataSeeder.EventImages);
    }

    private static LambdaExpression ConvertFilterExpression<TInterface>(
            Expression<Func<TInterface, bool>> filterExpression,
            Type entityType)
    {
        var newParam = Expression.Parameter(entityType);
        var newBody = ReplacingExpressionVisitor.Replace(filterExpression.Parameters.Single(), newParam, filterExpression.Body);

        return Expression.Lambda(newBody, newParam);
    }

    public DbSet<Event> Events { get; set; }
    public DbSet<EventImage> EventImages { get; set; }
    public DbSet<EventRegistration> EventRegistrations { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<UniversityUnit> UniversityUnits { get; set; }
}
