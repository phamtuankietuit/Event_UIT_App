using MediatR;
using Microsoft.AspNetCore.Mvc;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;

namespace UITEventAPI.Application.Features.Events;

public class GetEventTypesController : ApiControllerBase
{
    [HttpGet("events/types")]
    public async Task<IActionResult> GetEventTypes()
    {
        var result = await Sender.Send(new GetEventTypesQuery());
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public class GetEventTypesResponse
{
    public IEnumerable<string> EventTypes { get; set; } = [];
}

public record GetEventTypesQuery : IRequest<Result<GetEventTypesResponse>>;

public class GetEventTypesQueryHandler : IRequestHandler<GetEventTypesQuery, Result<GetEventTypesResponse>>
{
    public async Task<Result<GetEventTypesResponse>> Handle(GetEventTypesQuery request, CancellationToken cancellationToken)
    {
        var eventTypes = Enum.GetValues(typeof(EventType)).Cast<EventType>().Select(e => e.ToString());

        var response = new GetEventTypesResponse
        {
            EventTypes = eventTypes
        };

        return response;
    }
}