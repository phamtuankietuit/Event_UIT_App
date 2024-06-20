using Mapster;
using MapsterMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Features.Users;



public record RegisterResponse(string AccessToken, DateTime AccessTokenExpiration, string RefreshToken);

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber,
    string Password,
    DateTime DateOfBirth,
    string Role
) : IRequest<Result<RegisterResponse>>;

public class RegisterCommandHandler(
    IIdentityService identityService,
    ILogger<RegisterCommandHandler> logger
) : IRequestHandler<RegisterCommand, Result<RegisterResponse>>
{
    private readonly IIdentityService _identityService = identityService;
    private readonly ILogger<RegisterCommandHandler> _logger = logger;

    public async Task<Result<RegisterResponse>> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var result = await _identityService.CreateUserAsync(request);

            if (result.IsFailure)
            {
                return Result.Failure<RegisterResponse>(result.Error);
            }

            var tokenResponse = result.Value.Adapt<RegisterResponse>();

            return Result.Success(tokenResponse);
        }
        catch (Exception ex)
        {
            var commandName = nameof(RegisterCommand);
            
            _logger.LogError(ex, "Error registering user caused by command {CommandName}", commandName);

            throw;
        }
    }
}