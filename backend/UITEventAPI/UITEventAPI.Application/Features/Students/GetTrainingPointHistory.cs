using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Extensions;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.Students.GetTrainingPointHistoryResponse;

namespace UITEventAPI.Application.Features.Students;

public class GetTrainingPointHistoryController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.Student)]
    [HttpGet("students/me/training-point-history")]
    public async Task<IActionResult> GetTrainingPointHistory()
    {
        var userId = User.GetUserId();

        var userIdInt = int.Parse(userId!);
        var result = await Sender.Send(new GetTrainingPointHistoryQuery(userIdInt));
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetTrainingPointHistoryResponse(
    IEnumerable<TrainingPointHistoryDto> TrainingPointHistories
)
{
    public sealed record TrainingPointHistoryDto(
        int EventId,
        int TrainingPoint,
        string EventName,
        DateTime AttendDate
    );
}

public record GetTrainingPointHistoryQuery(int UserId) : IRequest<Result<GetTrainingPointHistoryResponse>>;

public class GetTrainingPointHistoryQueryHandler(
    ApplicationDbContext dbContext    
) : IRequestHandler<GetTrainingPointHistoryQuery, Result<GetTrainingPointHistoryResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<Result<GetTrainingPointHistoryResponse>> Handle(GetTrainingPointHistoryQuery request, CancellationToken cancellationToken)
    {
        var student = await _dbContext.Students.FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

        if (student == null)
        {
            return Result.Failure<GetTrainingPointHistoryResponse>(UserErrors.NotFound);
        }

        var trainingPointHistories = await _dbContext.EventRegistrations
            .Include(er => er.Event)
            .Where(er => er.StudentId == student.Id && er.IsAttended && er.Event.TrainingPoint > 0)
            .Select(er => new GetTrainingPointHistoryResponse.TrainingPointHistoryDto(
                er.Event.Id,
                er.Event.TrainingPoint,
                er.Event.Title,
                er.AttendedDate!.Value
            ))
            .ToListAsync(cancellationToken);

        return Result.Success(new GetTrainingPointHistoryResponse(trainingPointHistories));
    }
}
