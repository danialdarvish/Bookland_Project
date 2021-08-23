using System.Collections.Generic;
using _01_BooklandQuery.Contract.BookCategoryCount;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BookCategoriesSideBarViewComponent : ViewComponent
    {
        public List<BookCategoryCountQueryModel> BookCategories;
        private readonly IBookCategoryCountQuery _bookCategoryCountQuery;

        public BookCategoriesSideBarViewComponent(IBookCategoryCountQuery bookCategoryCountQuery)
        {
            _bookCategoryCountQuery = bookCategoryCountQuery;
        }

        public IViewComponentResult Invoke()
        {
            BookCategories = _bookCategoryCountQuery.GetSubCategoriesWithBookCount();
            return View(BookCategories);
        }
    }
}
