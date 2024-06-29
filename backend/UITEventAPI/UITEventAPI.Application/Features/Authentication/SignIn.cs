using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Features.Authentication;

public class SignInController : ApiControllerBase
{
    [HttpPost("auth/sign-in")]
    public async Task<IActionResult> SignIn(SignInQuery request)
    {
        var result = await Sender.Send(request);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record SignInResponse(string AccessToken, DateTime AccessTokenExpiration, string RefreshToken, string Role);

public record SignInQuery(string Email, string Password) : IRequest<Result<SignInResponse>>;

public class SignInHandler(
    IIdentityService identityService
) : IRequestHandler<SignInQuery, Result<SignInResponse>>
{
    public async Task<Result<SignInResponse>> Handle(SignInQuery request, CancellationToken cancellationToken)
    {
        var signInResult = await identityService.SignInAsync(request.Email, request.Password, cancellationToken);

        if (signInResult.IsFailure)
        {
            return Result.Failure<SignInResponse>(signInResult.Error);
        }

        var signInResponse = signInResult.Value.Adapt<SignInResponse>() with
        {
            Role = signInResult.Value.Role
        };

        return signInResponse;
    }
}
