using System.Collections.Generic;
using _01_BooklandQuery.Contract.Book;

namespace _01_BooklandQuery.Contract.BookCategory
{
    public class BookCategoryQueryModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string MetaDescription { get; set; }
        public long ParentId { get; set; }
        public List<BookQueryModel> Books{ get; set; }
        public List<BookCategoryQueryModel> Children { get; set; }

        public BookCategoryQueryModel()
        {
            Children = new List<BookCategoryQueryModel>();
            Books = new List<BookQueryModel>();
        }
    }
}
