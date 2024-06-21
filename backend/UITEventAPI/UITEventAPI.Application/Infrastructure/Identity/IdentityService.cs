using KKBookstore.Application.Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Extensions;
using UITEventAPI.Application.Features.Users;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Infrastructure.Identity;

public class IdentityService(
    UserManager<User> userManager,
    RoleManager<IdentityRole<int>> roleManager,
    IPasswordHasher<User> passwordHasher,
    IOptions<JwtSettings> jwtSettings,
    ApplicationDbContext dbContext
) : IIdentityService
{
    private readonly UserManager<User> _userManager = userManager;
    private readonly RoleManager<IdentityRole<int>> _roleManager = roleManager;
    private readonly IPasswordHasher<User> _passwordHasher = passwordHasher;
    private readonly IOptions<JwtSettings> _jwtSettings = jwtSettings;
    private readonly ApplicationDbContext _dbContext = dbContext;

    //public async Task<Result<TokenResponse>> CreateUserAsync(RegisterCommand request, CancellationToken cancellationToken)
    //{
    //    using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

    //    var searchResult = await FindUserByEmailAsync(request.Email);
    //    if (searchResult.IsSuccess)
    //    {
    //        return Result.Failure<TokenResponse>(UserErrors.AlreadyExists);
    //    }

    //    var role = await _roleManager.FindByNameAsync(request.Role);
    //    if (role == null)
    //    {
    //        return Result.Failure<TokenResponse>(UserErrors.InvalidRole);
    //    }

    //    var user = new User()
    //    {
    //        Email = request.Email,
    //        UserName = request.Email,
    //        PhoneNumber = request.PhoneNumber,
    //        IsActive = true,
    //    };

    //    user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);

    //    var result = await _userManager.CreateAsync(user, request.Password);
    //    if (!result.Succeeded)
    //    {
    //        var errors = result.ToErrors();
    //        await transaction.RollbackAsync();
    //        return Result.Failure<TokenResponse>(errors.FirstOrDefault() ?? UserErrors.CreateFailed);
    //    }

    //    var assignRoleResult = await _userManager.AddToRoleAsync(user, role.Name!);
    //    if (!assignRoleResult.Succeeded)
    //    {
    //        var errors = result.ToErrors();
    //        await transaction.RollbackAsync();
    //        return Result.Failure<TokenResponse>(errors.FirstOrDefault() ?? UserErrors.AssignRoleFailed);
    //    }

    //    await transaction.CommitAsync();

    //    // create a token response
    //    var responseResult = await GenerateTokenResponse(user);


    //    return responseResult;
    //}

    public async Task<Result<TokenResponse>> SignInAsync(SignInQuery request, CancellationToken cancellationToken)
    {
        var result = await FindUserByEmailAsync(request.Email);
        if (result.IsFailure)
        {
            return Result.Failure<TokenResponse>(UserErrors.InvalidCredentials);
        }

        var user = result.Value;
        var passwordValid = await _userManager.CheckPasswordAsync(user, request.Password);
        if (!passwordValid)
        {
            return Result.Failure<TokenResponse>(UserErrors.InvalidCredentials);
        }

        var responseResult = await GenerateTokenResponse(user);

        return responseResult;
    }

    //public async Task<Result> UpdateUserAsync(UpdateUserCommand command)
    //{
    //    var user = await _userManager.FindByIdAsync(command.Id.ToString());
    //    if (user == null)
    //    {
    //        return Result.Failure(UserErrors.NotFound);
    //    }

    //    // Update the user's properties
    //    mapper.Map(command, user);

    //    var result = await _userManager.UpdateAsync(user);
    //    if (!result.Succeeded)
    //    {
    //        return Result.Failure(result.ToErrors().FirstOrDefault() ?? UserErrors.UpdateFailed);
    //    }

    //    return Result.Success();
    //}

    //public async Task<Result> ReplaceUserAsync(ReplaceUserCommand request)
    //{
    //    var user = await _userManager.FindByIdAsync(request.Id.ToString());
    //    if (user == null)
    //    {
    //        return Result.Failure(UserErrors.NotFound);
    //    }

    //    // Update the user's properties
    //    mapper.Map(request, user);


    //    var result = await _userManager.UpdateAsync(user);
    //    if (!result.Succeeded)
    //    {
    //        return Result.Failure(result.ToErrors().FirstOrDefault() ?? UserErrors.UpdateFailed);
    //    }

    //    return Result.Success();
    //}


    //public async Task<Result<TokenResponse>> RefreshAccessToken(RefreshAccessToken request)
    //{
    //    // get the user send this
    //    var existingRefreshToken = await _dbContext.RefreshTokens
    //        .FirstOrDefaultAsync(rt => rt.Token == request.RefreshToken && rt.ExpiryDate > DateTimeOffset.UtcNow);

    //    if (existingRefreshToken == null)
    //    {
    //        return Result.Failure<TokenResponse>(TokenErrors.InvalidRefreshToken);
    //    }

    //    var user = await _userManager.FindByIdAsync(existingRefreshToken.UserId.ToString());
    //    if (user == null)
    //    {
    //        return Result.Failure<TokenResponse>(UserErrors.NotFound);
    //    }

    //    var responseResult = await GenerateTokenResponse(user);

    //    return responseResult;
    //}

    //public async Task<Result> UpdatePasswordAsync(UpdatePasswordCommand request)
    //{
    //    var userResult = await FindUserAsync(new(request.Email));

    //    if (userResult.IsFailure)
    //    {
    //        return Result.Failure(userResult.Error);
    //    }

    //    string resetToken = await _userManager.GeneratePasswordResetTokenAsync(userResult.Value);
    //    var result = await _userManager.ResetPasswordAsync(userResult.Value, resetToken, request.NewPassword);
    //    if (!result.Succeeded)
    //    {
    //        return Result.Failure(result.ToErrors().FirstOrDefault() ?? UserErrors.UpdateFailed);
    //    }

    //    return Result.Success();
    //}

    //public async Task<Result> ChangePasswordAsync(ChangePasswordCommand request)
    //{
    //    var userResult = await FindUserAsync(new(request.Email));
    //    if (userResult.IsFailure)
    //    {
    //        return Result.Failure(userResult.Error);
    //    }

    //    var passwordValid = await _userManager.CheckPasswordAsync(userResult.Value, request.CurrentPassword);

    //    if (!passwordValid)
    //    {
    //        return Result.Failure(UserErrors.InvalidCredentials);
    //    }

    //    var result = await _userManager.ChangePasswordAsync(userResult.Value, request.CurrentPassword, request.NewPassword);

    //    if (!result.Succeeded)
    //    {
    //        return Result.Failure(result.ToErrors().FirstOrDefault() ?? UserErrors.UpdateFailed);
    //    }

    //    return Result.Success();
    //}

    //public async Task<bool> IsValidRefreshToken(int userId, string refreshToken)
    //{
    //    var utcNow = DateTimeOffset.UtcNow;

    //    var existingRefreshToken = await _dbContext.RefreshTokens
    //        .FirstOrDefaultAsync(rt => rt.UserId == userId && rt.ExpiryDate > utcNow);

    //    if (existingRefreshToken != null)
    //    {
    //        return true;
    //    }

    //    return false;
    //}

    //public async Task<bool> IsInRoleAsync(int userId, string role)
    //{
    //    var user = await _userManager.FindByIdAsync(userId.ToString());

    //    return user != null && await _userManager.IsInRoleAsync(user, role);
    //}

    private async Task<Result<User>> FindUserByEmailAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);

        return user == null
            ? Result.Failure<User>(UserErrors.NotFound)
            : Result.Success(user);
    }

    private async Task<Result<TokenResponse>> GenerateTokenResponse(User user)
    {
        JwtSecurityToken accessToken = await GenerateAccessToken(user);
        var expires = accessToken.ValidTo;

        var refreshTokenResult = await GetRefreshToken(user.Id);
        if (refreshTokenResult.IsFailure)
        {
            return Result.Failure<TokenResponse>(refreshTokenResult.Error);
        }

        var refreshToken = refreshTokenResult.Value;

        return Result.Success(new TokenResponse(
            AccessToken: new JwtSecurityTokenHandler().WriteToken(accessToken),
            AccessTokenExpiration: expires,
            RefreshToken: refreshToken.Token
        ));
    }

    private async Task<JwtSecurityToken> GenerateAccessToken(User user)
    {
        var roles = await _userManager.GetRolesAsync(user);
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, user.Email!),
            new(ClaimTypes.Role, roles.FirstOrDefault()!)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Value.Secret));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var expires = DateTime.Now.AddDays(Convert.ToDouble(_jwtSettings.Value.AccessExpirationInDays));

        var token = new JwtSecurityToken(
            _jwtSettings.Value.Issuer,
            _jwtSettings.Value.Issuer,
            claims,
            expires: expires,
            signingCredentials: creds
        );

        return token;
    }

    private async Task<Result<RefreshToken>> GetRefreshToken(int userId)
    {
        var existingRefreshToken = await FindExistingRefreshToken(userId);

        if (existingRefreshToken != null)
        {
            return existingRefreshToken;
        }

        await RemoveExpiredRefreshTokens(userId);

        return await CreateAndSaveNewRefreshToken(userId);
    }

    private async Task<RefreshToken?> FindExistingRefreshToken(int userId)
    {
        var utcNow = DateTimeOffset.UtcNow;
        return await _dbContext.RefreshTokens
            .FirstOrDefaultAsync(rt => rt.UserId == userId && rt.ExpiryDate > utcNow);
    }

    private async Task RemoveExpiredRefreshTokens(int userId)
    {
        var utcNow = DateTimeOffset.UtcNow;
        var invalidRefreshTokens = await _dbContext.RefreshTokens
            .Where(rt => rt.UserId == userId && rt.ExpiryDate < utcNow)
            .ToListAsync();

        _dbContext.RefreshTokens.RemoveRange(invalidRefreshTokens);
        await _dbContext.SaveChangesAsync();
    }

    private async Task<Result<RefreshToken>> CreateAndSaveNewRefreshToken(int userId)
    {
        var refreshTokenResult = RefreshToken.Create(userId, _jwtSettings.Value.RefreshExpirationInMonths);
        if (refreshTokenResult.IsFailure)
        {
            return Result.Failure<RefreshToken>(refreshTokenResult.Error);
        }

        var refreshToken = refreshTokenResult.Value;
        await _dbContext.RefreshTokens.AddAsync(refreshToken);
        await _dbContext.SaveChangesAsync();

        return refreshToken;
    }
}