using System.Collections.Generic;
using _01_BooklandQuery.Contract.Article;
using _01_BooklandQuery.Contract.ArticleCategory;
using _01_BooklandQuery.Contract.Author;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleCategoryModel : PageModel
    {
        public List<AuthorQueryModel> Authors;
        public List<ArticleQueryModel> LatestArticles;
        public ArticleCategoryQueryModel ArticleCategory;
        public List<ArticleCategoryQueryModel> ArticleCategories;

        private readonly IAuthorQuery _authorQuery;
        private readonly IArticleQuery _articleQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;

        public ArticleCategoryModel(IArticleQuery articleQuery, IArticleCategoryQuery articleCategoryQuery, IAuthorQuery authorQuery)
        {
            _authorQuery = authorQuery;
            _articleQuery = articleQuery;
            _articleCategoryQuery = articleCategoryQuery;
        }


        public void OnGet(string id)
        {
            Authors = _authorQuery.GetBestAuthors();
            LatestArticles = _articleQuery.LatestArticles();
            ArticleCategory = _articleCategoryQuery.GetArticleCategory(id);
            ArticleCategories = _articleCategoryQuery.GetArticleCategories();
        }
    }
}
