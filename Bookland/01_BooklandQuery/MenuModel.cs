using System.Collections.Generic;
using _01_BooklandQuery.Contract.ArticleCategory;
using _01_BooklandQuery.Contract.BookCategory;

namespace _01_BooklandQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<BookCategoryQueryModel> BookCategories { get; set; }
    }
}
