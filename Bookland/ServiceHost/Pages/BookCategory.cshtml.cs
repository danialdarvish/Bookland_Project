using System.Collections.Generic;
using _01_BooklandQuery.Contract.BookCategory;
using _01_BooklandQuery.Contract.BookCategoryCount;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class BookCategoryModel : PageModel
    {
        public BookCategoryQueryModel BookCategory;
        public List<BookCategoryCountQueryModel> BookCategories;

        private readonly IBookCategoryQuery _bookCategoryQuery;
        private readonly IBookCategoryCountQuery _bookCategoryCountQuery;

        public BookCategoryModel(IBookCategoryQuery bookCategoryQuery, IBookCategoryCountQuery bookCategoryCountQuery)
        {
            _bookCategoryQuery = bookCategoryQuery;
            _bookCategoryCountQuery = bookCategoryCountQuery;
        }

        public void OnGet(string id)
        {
            BookCategory = _bookCategoryQuery.GetBookCategoryWithBookBy(id);
            BookCategories = _bookCategoryCountQuery.GetSubCategoriesWithBookCount();
        }
    }
}
