using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using JETech.Leasing.Web.Data.Entities;

namespace JETech.Leasing.Web.Models
{
    public class PropertyImageViewModel : PropertyImage
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
