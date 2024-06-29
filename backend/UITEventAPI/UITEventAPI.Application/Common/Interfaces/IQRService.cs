namespace UITEventAPI.Application.Common.Interfaces;

public interface IQRService
{
    byte[] GeneratePngQRCode(string text, int size = 1000);
}
