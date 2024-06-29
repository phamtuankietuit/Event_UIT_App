using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Numerics;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Extensions;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Events;

public class CheckinController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.Student)]
    [HttpPost("events/{eventId}/checkin")]
    public async Task<IActionResult> Checkin(int eventId, [FromBody] CheckinRequest request)
    {
        var userIdValue = User.GetUserId();
        if (userIdValue is null)
        {
            return Unauthorized();
        }
        
        if (eventId != request.EventId)
        {
            return BadRequest();
        }

        var command = request.Adapt<CheckinCommand>() with
        {
            UserId = int.Parse(userIdValue)
        };

        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record CheckinRequest(int EventId, int StudentCode);

public record CheckinResponse(bool Success, string Message);

public record CheckinCommand(int EventId, int StudentCode, int UserId) : IRequest<Result<CheckinResponse>>;

public class CheckinHandler(
    ApplicationDbContext dbContext,
    IDateTimeService dateTimeService,
    ILogger<CheckinHandler> logger
): IRequestHandler<CheckinCommand, Result<CheckinResponse>>
{
    private const int CheckInOffsetInMinutes = 15; 
    private readonly ApplicationDbContext _dbContext = dbContext;
    private readonly IDateTimeService _dateTimeService = dateTimeService;

    public async Task<Result<CheckinResponse>> Handle(CheckinCommand command, CancellationToken cancellationToken)
    {
        var student = await _dbContext.Students.FirstOrDefaultAsync(s => s.StudentCode == command.StudentCode, cancellationToken);
        if (student == null)
        {
            return Result.Failure<CheckinResponse>(EventErrors.AttendeeNotFound);
        }

        if (student.UserId != command.UserId)
        {
            return Result.Failure<CheckinResponse>(EventErrors.Unauthorized);
        }

        var currentEvent = await _dbContext.Events.FirstOrDefaultAsync(e => e.Id == command.EventId, cancellationToken);
        if (currentEvent == null) {
            return Result.Failure<CheckinResponse>(EventErrors.NotFound);
        }
        
        if (currentEvent.StartDate > _dateTimeService.Now || !currentEvent.IsPublished)
        {
            return Result.Failure<CheckinResponse>(EventErrors.EventNotStarted);
        }

        // if EndDate + 15 min < now => event ended
        if (currentEvent.EndDate.AddMinutes(CheckInOffsetInMinutes) < _dateTimeService.Now)
        {
            return Result.Failure<CheckinResponse>(EventErrors.EventEnded);
        }

        var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

        try
        {
            var registration = await _dbContext.EventRegistrations
                .FirstOrDefaultAsync(r => r.EventId == command.EventId && r.StudentId == student.Id, cancellationToken);

            if (registration == null)
            {
                var newRegistration = new EventRegistration
                {
                    EventId = command.EventId,
                    StudentId = student.Id,
                    IsAttended = true,
                    IsRegistered = true,
                    RegisterDate = _dateTimeService.Now,
                    AttendedDate = _dateTimeService.Now
                };

                await _dbContext.EventRegistrations.AddAsync(newRegistration, cancellationToken);
            }
            else if (!registration.IsAttended)
            {
                registration.IsAttended = true;
                registration.AttendedDate = _dateTimeService.Now;
            }


            await _dbContext.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);

            return Result.Success(new CheckinResponse(true, "Checkin successful"));
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(cancellationToken);
            logger.LogError(ex, "Checkin failed");
            return Result.Failure<CheckinResponse>(EventErrors.CheckinFailed);
        }
    }
}
