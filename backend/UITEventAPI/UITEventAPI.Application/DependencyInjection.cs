using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using UITEventAPI.Application.Common.Behaviors;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;
using UITEventAPI.Application.Infrastructure.Identity;

namespace UITEventAPI.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        services.AddMediatR(options =>
        {
            options.RegisterServicesFromAssembly(assembly);

            options.AddOpenBehavior(typeof(ValidationBehavior<,>));
            options.AddOpenBehavior(typeof(UnhandledExceptionBehaviour<,>));
        });

        return services;
    }

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        /// Config DbContext
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString)
                .EnableSensitiveDataLogging();

        });
        


        /// Config AuthN and AuthZ
        services.Configure<JwtSettings>(configuration.GetSection(nameof(JwtSettings)));
        services.AddScoped<IIdentityService, IdentityService>();
        var jwtSettings = configuration.GetSection(nameof(JwtSettings)).Get<JwtSettings>()!;
        services
            .AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, opt =>
            {
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret!))
                };
            });

        services.AddAuthorization();


        /// Config Identity
        services.AddIdentityCore<User>()
            .AddRoles<IdentityRole<int>>()
            .AddRoleManager<RoleManager<IdentityRole<int>>>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddApiEndpoints();

        return services;
    }
}
