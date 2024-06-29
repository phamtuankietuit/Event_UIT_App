using Azure.Storage.Blobs;
using Azure.Storage.Queues;
using KKBookstore.Infrastructure.Email;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Text;
using UITEventAPI.Application.Common.Interfaces;

namespace UITEventAPI.Application.Infrastructure.Email;

public class EmailService(
    IOptions<EmailConfiguration> emailConfiguration,
    QueueServiceClient queueServiceClient,
    BlobServiceClient blobServiceClient
) : IEmailService
{
    private readonly string SenderName = "UITEvent";
    private readonly string ReceiverName = "Customer";
    private readonly string _queueName = "mail-trigger";
    private readonly string _blobContainerName = "mail-body";

    private readonly EmailConfiguration _emailConfig = emailConfiguration.Value;
    private readonly QueueServiceClient _queueServiceClient = queueServiceClient;
    private readonly BlobServiceClient _blobServiceClient = blobServiceClient;

    // email templates

    private readonly EmailTemplate sendOtpEmailTemplate = new()
    {
        Subject = "Your One-Time Passcode(OTP) - UITEvent",
        Body = @"<!DOCTYPE html>
<html>
<head>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            color: #333;
        }

        .container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #f5f5f5;
            border-radius: 5px;
        }

        h1 {
            color: #007bff; 
        }

        .otp {
            font-size: 24px;
            font-weight: bold;
            background-color: #fff;
            padding: 15px;
            border-radius: 5px;
            margin-bottom: 20px;
            text-align: left; /* Căn giữa mã OTP */
        }

        .highlight { /* Thêm lớp CSS để làm nổi bật mã OTP */
            background-color: #f0f0f0;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <h1>Xin chào {userName},</h1>
        <p>Bạn vừa yêu cầu mã xác thực OTP cho tài khoản UITEvent của mình.</p>
        <div class=""otp highlight"">
            Mã OTP của bạn là: {otp}
        </div>
        <p>Vui lòng nhập mã này trong vòng 5 phút tới.</p>

        <h2>Vì lý do bảo mật, vui lòng không chia sẻ mã này với bất kỳ ai.</h2>

        <p>Nếu bạn không yêu cầu mã OTP, vui lòng bỏ qua email này. Sự an toàn của tài khoản là rất quan trọng với chúng tôi. Nếu bạn nghi ngờ có hoạt động trái phép, vui lòng liên hệ với chúng tôi ngay lập tức tại <a href=""mailto:{AdminEmail}"">{AdminEmail}</a>.</p>

        <p>Trân trọng,</p>
        <p>Đội ngũ EventUIT</p>
    </div>
</body>
</html>"
    };

    public async Task SendOtp(string email, string otp)
    {
        var message = CreateEmailMessage(
            sendOtpEmailTemplate.Subject,
            sendOtpEmailTemplate.Body,
            email,
            new Dictionary<string, string>()
            {
                { "{otp}", otp},
                { "{AdminEmail}", _emailConfig.From},
                { "{userName}", email},
            }
        );

        await SendAsync(message);
    }

    private MimeMessage CreateEmailMessage(string subject, string body, string toEmail, Dictionary<string, string>? placeholders = null)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(SenderName, _emailConfig.From));
        message.To.Add(new MailboxAddress(ReceiverName, toEmail));
        message.Subject = subject;

        if (placeholders != null)
        {
            foreach (var placeholder in placeholders)
            {
                body = body.Replace(placeholder.Key, placeholder.Value);
            }
        }

        message.Body = new TextPart("plain") { Text = body };

        return message;
    }

    private async Task SendAsync(MimeMessage mailMessage)
    {
        var queueClient = _queueServiceClient.GetQueueClient(_queueName);

        var blobContainerClient = _blobServiceClient.GetBlobContainerClient(_blobContainerName);
        await blobContainerClient.CreateIfNotExistsAsync();

        var blobName = "mail-body-" + Guid.NewGuid().ToString();

        using (var stream = new MemoryStream())
        {
            mailMessage.WriteTo(stream);

            var blobClient = blobContainerClient.GetBlobClient(blobName);
            stream.Position = 0;
            await blobClient.UploadAsync(stream);
        }

        var blobNameBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(blobName));
        await queueClient.SendMessageAsync(blobNameBase64);
    }
}
