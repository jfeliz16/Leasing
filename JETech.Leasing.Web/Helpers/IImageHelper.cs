using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace JETech.Leasing.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}
