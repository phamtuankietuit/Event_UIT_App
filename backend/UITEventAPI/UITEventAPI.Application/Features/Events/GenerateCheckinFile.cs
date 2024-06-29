using ClosedXML.Excel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Events;

public class GenerateCheckinFileController : ApiControllerBase
{
    [HttpPost("events/generate-checkin-file")]
    public async Task<IActionResult> GenerateCheckinFile([FromBody] GenerateCheckinFileCommand request)
    {
        var result = await Sender.Send(request);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GenerateCheckinFileResponse(string FileUrl);

public record GenerateCheckinFileCommand(int EventId) : IRequest<Result<GenerateCheckinFileResponse>>;

public class GenerateCheckinFileHandler(
    ApplicationDbContext dbContext,
    IBlobService blobService,
    IDateTimeService dateTimeService
) : IRequestHandler<GenerateCheckinFileCommand, Result<GenerateCheckinFileResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;
    private readonly IBlobService _blobService = blobService;
    private readonly IDateTimeService _dateTimeService = dateTimeService;

    public async Task<Result<GenerateCheckinFileResponse>> Handle(GenerateCheckinFileCommand request, CancellationToken cancellationToken)
    {
        var eventInfo = await _dbContext.Events
            .Where(e => e.Id == request.EventId)
            .Include(e => e.Registrations)
                .ThenInclude(r => r.Student)
            .FirstOrDefaultAsync(cancellationToken);

        if (eventInfo == null)
        {
            return Result.Failure<GenerateCheckinFileResponse>(EventErrors.NotFound);
        }

        if (eventInfo.StartDate > _dateTimeService.Now)
        {
            return Result.Failure<GenerateCheckinFileResponse>(EventErrors.EventNotStarted);
        }

        if (eventInfo.EndDate > _dateTimeService.Now)
        {
            return Result.Failure<GenerateCheckinFileResponse>(EventErrors.EventNotEnded);
        }

        if (eventInfo.CheckinFileUrl != null)
        {
            return new GenerateCheckinFileResponse(eventInfo.CheckinFileUrl);
        }

        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Checkin");
        worksheet.Cell("A1").Value = "STT";
        worksheet.Cell("B1").Value = "Thời gian đăng ký";
        worksheet.Cell("C1").Value = "Thời gian điểm danh";
        worksheet.Cell("D1").Value = "MSSV";
        worksheet.Cell("E1").Value = "Họ và tên";

        int row = 2;
        foreach (var registration in eventInfo.Registrations)
        {
            worksheet.Cell($"A{row}").Value = row - 1;
            worksheet.Cell($"B{row}").Value = registration.RegisterDate.ToString("HH:mm, dd/MM/yyyy");
            worksheet.Cell($"C{row}").Value = registration.AttendedDate?.ToString("HH:mm, dd/MM/yyyy");
            worksheet.Cell($"D{row}").Value = registration.Student.StudentCode;
            worksheet.Cell($"E{row}").Value = registration.Student.FullName;
            row++;
        }

        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        stream.Position = 0;

        
        string fileUrl = await SaveFileAndGetUrlAsync(stream, eventInfo.Id, cancellationToken);

        eventInfo.CheckinFileUrl = fileUrl;
        _dbContext.Events.Update(eventInfo);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return new GenerateCheckinFileResponse(fileUrl);
    }

    private async Task<string> SaveFileAndGetUrlAsync(MemoryStream memoryStream, int eventId, CancellationToken cancellationToken)
    {
        var fileName = $"{eventId}-{_dateTimeService.NowInFileName}.xlsx";
        var uri = await _blobService.UploadFileAsync("checkin-excel", fileName, "xlsx", memoryStream);

        return uri.AbsoluteUri;
    }
}