using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Extensions;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Events;

public class RegisterEventController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.Student)]
    [HttpPost("events/{id}/register")]
    public async Task<IActionResult> RegisterEvent(int id, [FromBody] RegisterEventRequest request)
    {
        if (id != request.EventId)
        {
            return BadRequest();
        }
        
        var userIdValue = User.GetUserId();
        if (userIdValue is null)
        {
            return Unauthorized();
        }

        var command = request.Adapt<RegisterEventCommand>() with
        {
            UserId = int.Parse(userIdValue)
        };


        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record RegisterEventRequest(int EventId, int StudentId);

public record RegisterEventResponse(bool Success, string Message);

public record RegisterEventCommand(int EventId, int StudentId, int UserId) : IRequest<Result<RegisterEventResponse>>;

public class RegisterEventHandler(
    ApplicationDbContext dbContext,
    IDateTimeService dateTimeService
) : IRequestHandler<RegisterEventCommand, Result<RegisterEventResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;
    private readonly IDateTimeService _dateTimeService = dateTimeService;

    public async Task<Result<RegisterEventResponse>> Handle(RegisterEventCommand command, CancellationToken cancellationToken)
    {
        var student = await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == command.StudentId, cancellationToken);
        if (student == null)
        {
            return Result.Failure<RegisterEventResponse>(EventErrors.AttendeeNotFound);
        }

        if (student.UserId != command.UserId)
        {
            return Result.Failure<RegisterEventResponse>(EventErrors.Unauthorized);
        }

        var eventObj = await _dbContext.Events.FirstOrDefaultAsync(e => e.Id == command.EventId, cancellationToken);
        if (eventObj == null)
        {
            return Result.Failure<RegisterEventResponse>(EventErrors.NotFound);
        }

        if (eventObj.StartDate < _dateTimeService.Now)
        {
            return Result.Failure<RegisterEventResponse>(EventErrors.OnlyAvailableBeforeEventStart);
        }

        var registration = await _dbContext.EventRegistrations.FirstOrDefaultAsync(r => r.EventId == command.EventId && r.StudentId == command.StudentId && r.IsRegistered, cancellationToken);
        if (registration != null)
        {
            return Result.Failure<RegisterEventResponse>(EventErrors.AlreadyRegistered);
        }

        var newRegistration = new EventRegistration
        {
            EventId = command.EventId,
            StudentId = command.StudentId,
            RegisterDate = _dateTimeService.Now
        };

        await _dbContext.EventRegistrations.AddAsync(newRegistration, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return Result.Success(new RegisterEventResponse(true, "Registered successfully"));
    }
}