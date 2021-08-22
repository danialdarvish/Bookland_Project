using _01_BooklandQuery.Contract.BookCategory;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class BookCategoryModel : PageModel
    {
        public BookCategoryQueryModel BookCategory;
        private readonly IBookCategoryQuery _bookCategoryQuery;

        public BookCategoryModel(IBookCategoryQuery bookCategoryQuery)
        {
            _bookCategoryQuery = bookCategoryQuery;
        }

        public void OnGet(string id)
        {
            BookCategory = _bookCategoryQuery.GetBookCategoryWithBookBy(id);
        }
    }
}
