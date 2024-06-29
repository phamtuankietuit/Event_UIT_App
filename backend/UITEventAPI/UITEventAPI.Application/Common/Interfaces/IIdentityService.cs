using KKBookstore.Application.Common.Models;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Features.Authentication;

namespace UITEventAPI.Application.Common.Interfaces;

public interface IIdentityService
{
    Task<Result<TokenResponseWithRole>> SignInAsync(string email, string password, CancellationToken cancellationToken);
    Task<Result> UpdatePasswordAsync(string email, string newPassword, CancellationToken cancellationToken);
    Task<Result> ChangePasswordAsync(string email, string oldPassword, string newPassword, CancellationToken cancellationToken);
    //Task<Result> UpdateUserAsync(UpdateUserCommand command);
    //Task<Result> ReplaceUserAsync(ReplaceUserCommand request);
    //Task<Result<TokenResponse>> RefreshAccessToken(RefreshAccessToken request);
    //Task<Result<TokenResponse>> CreateUserAsync(RegisterCommand request, CancellationToken cancellationToken);
}
