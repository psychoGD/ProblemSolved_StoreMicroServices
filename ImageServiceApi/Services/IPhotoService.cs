using ImageServiceApi.Dtos;

namespace ImageServiceApi.Services
{
    public interface IPhotoService
    {
        string UploadImage(IFormFile dto);
    }
}
