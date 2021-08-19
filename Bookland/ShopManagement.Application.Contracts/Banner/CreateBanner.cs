using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using ShopManagement.Application.Contracts.Book;

namespace ShopManagement.Application.Contracts.Banner
{
    public class CreateBanner
    {
        public IFormFile Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Tag { get; set; }
        public long BookId { get; set; }

        public List<BookViewModel> Books { get; set; }
    }
}
