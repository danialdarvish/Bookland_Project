using _01_BooklandQuery.Contract.BookCategoryCount;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BookCountViewComponent : ViewComponent
    {
        private readonly IBookCategoryCountQuery _bookCategoryCountQuery;

        public BookCountViewComponent(IBookCategoryCountQuery bookCategoryCountCountQuery)
        {
            _bookCategoryCountQuery = bookCategoryCountCountQuery;
        }

        public IViewComponentResult Invoke()
        {
            var bookCount = _bookCategoryCountQuery.GetMainCategoriesWithBookCount();
            return View(bookCount);
        }
    }
}
