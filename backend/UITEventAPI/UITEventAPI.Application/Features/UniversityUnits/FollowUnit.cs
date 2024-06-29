using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.UniversityUnits;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.UniversityUnits;

public class FollowUnitController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.Student)]
    [HttpPost("university-units/{id}/follow")]
    public async Task<IActionResult> FollowUnit(
        [FromRoute] int id,
        [FromBody] FollowUnitCommand command
    )
    {
        if (id != command.UnitId)
        {
            return BadRequest();
        }

        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record FollowUnitResponse(string Message);

public record FollowUnitCommand(int StudentId, int UnitId, string? DeviceToken) : IRequest<Result<FollowUnitResponse>>;

public class FollowUnitCommandHandler(
    ApplicationDbContext dbContext,
    IDateTimeService dateTimeService,
    INotificationService notificationService
): IRequestHandler<FollowUnitCommand, Result<FollowUnitResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;
    private readonly IDateTimeService _dateTimeService = dateTimeService;
    private readonly INotificationService _notificationService = notificationService;

    public async Task<Result<FollowUnitResponse>> Handle(FollowUnitCommand request, CancellationToken cancellationToken)
    {
        var student = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == request.StudentId, cancellationToken);
        if (student == null)
            return Result.Failure<FollowUnitResponse>(UserErrors.NotFound);

        var unit = await _dbContext.UniversityUnits.FirstOrDefaultAsync(x => x.Id == request.UnitId, cancellationToken);
        if (unit == null)
            return Result.Failure<FollowUnitResponse>(UserErrors.NotFound);

        var currFollow = await _dbContext.UnitFollows.FirstOrDefaultAsync(x => x.StudentId == request.StudentId && x.UniversityUnitId == request.UnitId, cancellationToken);


        using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);
        string message = "Followed unit successfully";
        if (currFollow != null)
        {
            currFollow.IsFollowed = !currFollow.IsFollowed;
            currFollow.FollowedDate = !currFollow.IsFollowed ? null : _dateTimeService.Now;
            message = currFollow.IsFollowed ? message : "Unfollowed unit successfully";
        }
        else
        {
            _dbContext.UnitFollows.Add(new UnitFollow
            {
                StudentId = request.StudentId,
                UniversityUnitId = request.UnitId,
                IsFollowed = true,
                FollowedDate = _dateTimeService.Now
            });
        }

        try
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);
        }
        catch (DbUpdateConcurrencyException)
        {
            await transaction.RollbackAsync(cancellationToken);
            return Result.Failure<FollowUnitResponse>(UniversityUnitErrors.FollowFailed);
        }

        // after success follow/unfollow unit, subscribe/unsubscribe the device of this student to the unit topic
        if (!string.IsNullOrEmpty(request.DeviceToken))
        {
            if (currFollow == null || currFollow.IsFollowed)
            {
                await _notificationService.SubcribeToTopicAsync(unit.Id.ToString(), request.DeviceToken);
            }
            else
            {
                await _notificationService.UnSubcribeToTopicAsync(unit.Id.ToString(), request.DeviceToken);
            }
        }

        return Result.Success(new FollowUnitResponse(message));
    }
}
