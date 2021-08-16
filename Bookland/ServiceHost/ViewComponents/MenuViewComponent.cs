using _01_BooklandQuery;
using _01_BooklandQuery.Contract.ArticleCategory;
using _01_BooklandQuery.Contract.BookCategory;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IBookCategoryQuery _bookCategoryQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public MenuViewComponent(IBookCategoryQuery bookCategoryQuery, IArticleCategoryQuery articleCategoryQuery)
        {
            _bookCategoryQuery = bookCategoryQuery;
            _articleCategoryQuery = articleCategoryQuery;
        }


        public IViewComponentResult Invoke()
        {
            var result = new MenuModel
            {
                BookCategories = _bookCategoryQuery.GetBookCategories(),
                ArticleCategories = _articleCategoryQuery.GetArticleCategories()
            };
            return View(result);
        }
    }
}
