using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Events;

public class GenerateEventQRController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.UnitAdmin)]
    [HttpPost("events/{id}/qr")]
    public async Task<IActionResult> GenerateEventQR(int id, [FromBody] GenerateEventQRCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GenerateEventQRResponse(string QRImageUrl);

public record GenerateEventQRCommand(int Id) : IRequest<Result<GenerateEventQRResponse>>;

public class GenerateEventQRHandler(
    ApplicationDbContext dbContext,
    IBlobService blobService,
    IDateTimeService dateTimeService,
    IQRService QRService
) : IRequestHandler<GenerateEventQRCommand, Result<GenerateEventQRResponse>>
{
    private const int GenerateQRBeforeDays = 1;
    private readonly ApplicationDbContext _dbContext = dbContext;
    private readonly IBlobService _blobService = blobService;
    private readonly IDateTimeService _dateTimeService = dateTimeService;
    private readonly IQRService _QRService = QRService;

    public async Task<Result<GenerateEventQRResponse>> Handle(GenerateEventQRCommand request, CancellationToken cancellationToken)
    {
        var currentEvent = await _dbContext.Events.FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken);

        if (currentEvent == null)
        {
            return Result.Failure<GenerateEventQRResponse>(EventErrors.NotFound);
        }

        var qrContent = $"{currentEvent.Id}";

        var qrImage = _QRService.GeneratePngQRCode(qrContent);

        var fileName = $"event-{currentEvent.Id}-{_dateTimeService.NowInFileName}.png";
        var qrImageUrl = await _blobService.UploadImageAsync("qrcodes", fileName, "png", new MemoryStream(qrImage));

        currentEvent.QRImageUrl = qrImageUrl.AbsoluteUri;
        
        _dbContext.Events.Update(currentEvent);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return Result.Success(new GenerateEventQRResponse(qrImageUrl.AbsoluteUri));
    }
}