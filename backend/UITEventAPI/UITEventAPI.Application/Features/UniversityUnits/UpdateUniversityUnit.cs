using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.UniversityUnits;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.UniversityUnits;

public class UpdateUniversityUnitController : ApiControllerBase
{
    [HttpPut("university-units/{universityUnitId}")]
    public async Task<IActionResult> UpdateUniversityUnit([FromRoute] int universityUnitId, [FromBody] UpdateUniversityUnitCommand command)
    {
        if (universityUnitId != command.UniversityUnitId)
            return BadRequest();

        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok() : ToActionResult(result);
    }
}

public record UpdateUniversityUnitCommand(
    int UniversityUnitId,
    string Name,
    string Description,
    string FacebookUrl,
    string AvatarUrl
) : IRequest<Result>;

public class UpdateUniversityUnitCommandHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<UpdateUniversityUnitCommand, Result>
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<Result> Handle(UpdateUniversityUnitCommand request, CancellationToken cancellationToken)
    {
        var universityUnit = await _dbContext.UniversityUnits
            .Where(x => x.Id == request.UniversityUnitId)
            .Include(x => x.User)
            .FirstOrDefaultAsync(cancellationToken);

        if (universityUnit == null)
            return Result.Failure(UniversityUnitErrors.NotFound);

        var updateResult = await UpdateUniversityUnit(request, universityUnit);

        return updateResult;
    }

    private async Task<Result> UpdateUniversityUnit(UpdateUniversityUnitCommand request, UniversityUnit universityUnit)
    {
        universityUnit.Name = request.Name;
        universityUnit.Description = request.Description;
        universityUnit.FacebookUrl = request.FacebookUrl;
        universityUnit.User.AvatarUrl = request.AvatarUrl;

        _dbContext.UniversityUnits.Update(universityUnit);
        _dbContext.Users.Update(universityUnit.User);

        await _dbContext.SaveChangesAsync();

        return Result.Success();
    }
}