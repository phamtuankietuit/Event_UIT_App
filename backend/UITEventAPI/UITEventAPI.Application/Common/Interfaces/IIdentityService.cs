using KKBookstore.Application.Common.Models;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Features.Users;

namespace UITEventAPI.Application.Common.Interfaces;

public interface IIdentityService
{
    Task<Result<TokenResponse>> CreateUserAsync(RegisterCommand request);
    //Task<Result> UpdateUserAsync(UpdateUserCommand command);
    //Task<Result> ReplaceUserAsync(ReplaceUserCommand request);
    //Task<Result<TokenResponse>> SignInAsync(SignInCommand request);
    //Task<Result<TokenResponse>> RefreshAccessToken(RefreshAccessToken request);
    //Task<Result> UpdatePasswordAsync(UpdatePasswordCommand request);
    //Task<Result> ChangePasswordAsync(ChangePasswordCommand request);
}
