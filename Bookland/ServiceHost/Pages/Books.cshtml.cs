using System.Collections.Generic;
using _01_BooklandQuery.Contract.Book;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class BooksModel : PageModel
    {
        public string Value;
        public List<BookQueryModel> Books;

        private readonly IBookQuery _bookQuery;

        public BooksModel(IBookQuery bookQuery)
        {
            _bookQuery = bookQuery;
        }


        public void OnGet(string value)
        {
            Value = value;
            Books = _bookQuery.Search(value);
        }
    }
}
