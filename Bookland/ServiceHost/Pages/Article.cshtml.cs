using System.Collections.Generic;
using _01_BooklandQuery.Contract.Article;
using _01_BooklandQuery.Contract.ArticleCategory;
using _01_BooklandQuery.Contract.Author;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ArticleModel : PageModel
    {
        public ArticleQueryModel Article;
        public List<AuthorQueryModel> Authors;
        public List<ArticleQueryModel> LatestArticles;
        public List<ArticleCategoryQueryModel> ArticleCategories;

        private readonly IAuthorQuery _authorQuery;
        private readonly IArticleQuery _articleQuery;
        private readonly IArticleCategoryQuery _articleCategoryQuery;
        private readonly ICommentApplication _commentApplication;

        public ArticleModel(IArticleQuery articleQuery, IArticleCategoryQuery articleCategoryQuery, ICommentApplication commentApplication, IAuthorQuery authorQuery)
        {
            _authorQuery = authorQuery;
            _articleQuery = articleQuery;
            _articleCategoryQuery = articleCategoryQuery;
            _commentApplication = commentApplication;
        }


        public void OnGet(string id)
        {
            Article = _articleQuery.GetArticleDetails(id);
            LatestArticles = _articleQuery.LatestArticles();
            ArticleCategories = _articleCategoryQuery.GetArticleCategories();
            Authors = _authorQuery.GetBestAuthors();
        }

        public IActionResult OnPost(AddComment command, string articleSlug)
        {
            command.Type = CommentType.Article;
            if (ModelState.IsValid)
            {
                _commentApplication.Add(command);
            }
            return RedirectToPage("/Article", new { Id = articleSlug });
        }
    }
}
