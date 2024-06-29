using QRCoder;
using UITEventAPI.Application.Common.Interfaces;

namespace UITEventAPI.Application.Infrastructure.QRCodes;

public class QRService : IQRService
{
    public byte[] GeneratePngQRCode(string text, int size = 1000)
    {
        using var qrGenerator = new QRCodeGenerator();
        var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);

        // Use the QRCode class to create a bitmap from the qrCodeData
        using var qrCode = new PngByteQRCode(qrCodeData);
        
        var qrCodeImage = qrCode.GetGraphic(size);

        return qrCodeImage;
    }
}
