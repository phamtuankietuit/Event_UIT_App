using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Identity;

namespace UITEventAPI.Application.Infrastructure.Data;

public class ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options
) : IdentityDbContext<User, IdentityRole<int>, int>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.ApplyConfigurationsFromAssembly(typeof(RefreshToken).Assembly);


        foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }

        builder.Model.GetEntityTypes()
            .Where(entityType => typeof(ISoftDeleteEntity).IsAssignableFrom(entityType.ClrType))
            .ToList()
            .ForEach(et =>
                builder.Entity(et.ClrType)
                    .HasQueryFilter(ConvertFilterExpression<ISoftDeleteEntity>(e => !e.IsDeleted, et.ClrType))
            );

        //DataSeeder.Seed(builder);
    }

    private static LambdaExpression ConvertFilterExpression<TInterface>(
            Expression<Func<TInterface, bool>> filterExpression,
            Type entityType)
    {
        var newParam = Expression.Parameter(entityType);
        var newBody = ReplacingExpressionVisitor.Replace(filterExpression.Parameters.Single(), newParam, filterExpression.Body);

        return Expression.Lambda(newBody, newParam);
    }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
}
