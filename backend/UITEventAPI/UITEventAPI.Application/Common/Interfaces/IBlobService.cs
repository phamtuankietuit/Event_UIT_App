using System.Globalization;

namespace UITEventAPI.Application.Common.Interfaces;

public interface IBlobService
{
    Task<Uri> UploadFileAsync(string containerName, string fileName, string contentType, Stream content);
    Task<Uri> UploadImageAsync(string containerName, string fileName, string base64String);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="containerName"></param>
    /// <param name="fileName"></param>
    /// <param name="imageType">png or jpg</param>
    /// <param name="content"></param>
    /// <returns></returns>
    Task<Uri> UploadImageAsync(string containerName, string fileName, string imageType, Stream content);
    Task DeleteFileAsync(string containerName, string fileName);
    //Task DeleteContainerAsync(string containerName);
    //Task<bool> ContainerExistsAsync(string containerName);
    //Task<bool> FileExistsAsync(string containerName, string fileName);
    //Task<Uri> GetFileUriAsync(string containerName, string fileName);
    //Task<IEnumerable<Uri>> ListFilesAsync(string containerName);
}
