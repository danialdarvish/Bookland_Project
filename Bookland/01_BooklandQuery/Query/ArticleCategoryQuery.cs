using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Article;
using _01_BooklandQuery.Contract.ArticleCategory;
using _01_Framework.Application;
using BlogManagement.Domain.ArticleAgg;
using BlogManagement.Infrastructure.EFCore;
using CommentManagement.Domain.CommentAgg;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_BooklandQuery.Query
{
    public class ArticleCategoryQuery : IArticleCategoryQuery
    {
        private readonly BlogContext _context;
        private readonly CommentContext _commentContext;
        public ArticleCategoryQuery(BlogContext context, CommentContext commentContext)
        {
            _context = context;
            _commentContext = commentContext;
        }


        public ArticleCategoryQueryModel GetArticleCategory(string slug)
        {
            var comments = _commentContext.Comments
                .Where(x => x.Type == CommentType.Article).ToList();

            var articleCategory = _context.ArticleCategories
                .Include(x => x.Articles)
                .Select(x => new ArticleCategoryQueryModel
                {
                    Slug = x.Slug,
                    Name = x.Name,
                    Description = x.Description,
                    Picture = x.Picture,
                    PictureTitle = x.PictureTitle,
                    PictureAlt = x.PictureAlt,
                    CanonicalAddress = x.CanonicalAddress,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    ArticlesCount = x.Articles.Count,
                    Articles = MapArticles(x.Articles, comments)
                }).FirstOrDefault(x => x.Slug == slug);

            if (articleCategory != null)
                articleCategory.KeywordList = articleCategory.Keywords.Split(",").ToList();

            return articleCategory;

        }

        private static List<ArticleQueryModel> MapArticles(List<Article> articles, List<Comment> comments)
        {
            return articles.Select(x => new ArticleQueryModel
            {
                Slug = x.Slug,
                ShortDescription = x.ShortDescription,
                Title = x.Title,
                Picture = x.Picture,
                PictureTitle = x.PictureTitle,
                PictureAlt = x.PictureAlt,
                PublishDate = x.PublishDate.ToFarsi(),
                CommentCount = CountComments(x.Id, comments)
            }).ToList();
        }

        private static string CountComments(long articleId, List<Comment> comments)
        {
            return comments.Where(x => x.OwnerRecordId == articleId).Count().ToString();
        }

        public List<ArticleCategoryQueryModel> GetArticleCategories()
        {
            return _context.ArticleCategories
                .Include(x => x.Articles)
                .Select(x => new ArticleCategoryQueryModel
                {
                    Name = x.Name,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    ArticlesCount = x.Articles.Count
                }).ToList();
        }
    }
}
