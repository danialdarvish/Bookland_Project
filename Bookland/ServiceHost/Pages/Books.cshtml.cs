using System.Collections.Generic;
using _01_BooklandQuery.Contract.Banner;
using _01_BooklandQuery.Contract.Book;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class BooksModel : PageModel
    {
        public string Value;
        public BannerQueryModel Banner;
        public List<BookQueryModel> Books;

        private readonly IBookQuery _bookQuery;
        private readonly IBannerQuery _bannerQuery;

        public BooksModel(IBookQuery bookQuery, IBannerQuery bannerQuery)
        {
            _bookQuery = bookQuery;
            _bannerQuery = bannerQuery;
        }


        public void OnGet(string value)
        {
            Value = value;
            Banner = _bannerQuery.GetBanner();
            Books = _bookQuery.Search(value);
        }
    }
}
