using System.ComponentModel.DataAnnotations;
using _01_Framework.Application;
using Microsoft.AspNetCore.Http;

namespace ShopManagement.Application.Contracts.Quote
{
    public class CreateQuote
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PersonName { get; set; }
        public string PersonPost { get; set; }
        public string Text { get; set; }

        [MaxFileSize(1 * 1024 * 1024, ErrorMessage = ValidationMessages.MaxFileSize)]
        public IFormFile PersonPicture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
    }
}
