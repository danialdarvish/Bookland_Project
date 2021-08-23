using System.Collections.Generic;
using _01_BooklandQuery.Contract.Book;
using ShopManagement.Application.Contracts.Book;

namespace _01_BooklandQuery.Contract.Author
{
    public class AuthorQueryModel
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public int BooksCount { get; set; }
        public List<BookQueryModel> Books { get; set; }
    }
}
