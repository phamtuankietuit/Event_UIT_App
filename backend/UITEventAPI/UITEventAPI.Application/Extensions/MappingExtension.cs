using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Extensions;

public static class MappingExtension
{
    public static Error[] ToErrors(this IdentityResult result)
    {
        if (!result.Errors.Any())
            return [];

        return result.Errors.Select(x => Error.Validation(x.Code, x.Description)).ToArray();
    }
}
