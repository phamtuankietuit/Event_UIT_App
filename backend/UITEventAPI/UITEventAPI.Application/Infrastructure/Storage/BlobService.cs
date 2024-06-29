using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using UITEventAPI.Application.Common.Interfaces;

namespace UITEventAPI.Application.Infrastructure.Storage;

public class BlobService(
    BlobServiceClient blobServiceClient
) : IBlobService
{
    private readonly BlobServiceClient blobServiceClient = blobServiceClient;

    public async Task DeleteFileAsync(string containerName, string fileName)
    {
        var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        var blobClient = containerClient.GetBlobClient(fileName);
        await blobClient.DeleteAsync();
    }

    public async Task<Uri> UploadFileAsync(string containerName, string fileName, string contentType, Stream content)
    {
        var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync();

        var blobClient = containerClient.GetBlobClient(fileName);

        await blobClient.UploadAsync(content, new BlobUploadOptions { HttpHeaders = new BlobHttpHeaders { ContentType = contentType } });

        return blobClient.Uri;
    }

    public async Task<Uri> UploadImageAsync(string containerName, string fileName, string base64String)
    {
        var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync();

        var blobClient = containerClient.GetBlobClient(fileName);

        var contentType = base64String[0] == '/' ? "image/jpeg" : "image/png";

        var bytes = Convert.FromBase64String(base64String);
        await blobClient.UploadAsync(new MemoryStream(bytes), new BlobHttpHeaders { ContentType = contentType });

        return blobClient.Uri;
    }

    public async Task<Uri> UploadImageAsync(string containerName, string fileName, string imageType, Stream content)
    {
        var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync();

        var blobClient = containerClient.GetBlobClient(fileName);

        var contentType = imageType == "jpg" ? "image/jpeg" : "image/png";

        await blobClient.UploadAsync(content, new BlobHttpHeaders { ContentType = contentType });

        return blobClient.Uri;
    }
}
