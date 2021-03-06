using System;
using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Article;
using _01_BooklandQuery.Contract.Comment;
using _01_Framework.Application;
using BlogManagement.Infrastructure.EFCore;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_BooklandQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;
        private readonly CommentContext _commentContext;

        public ArticleQuery(BlogContext context, CommentContext commentContext)
        {
            _context = context;
            _commentContext = commentContext;
        }


        public ArticleQueryModel GetArticleDetails(string slug)
        {
            var article = _context.Articles
                .Where(x => x.PublishDate <= DateTime.Now)
                .Include(x => x.Category)
                .Select(x => new ArticleQueryModel
                {
                    Id = x.Id,
                    CategoryName = x.Category.Name,
                    CategoryId = x.CategoryId,
                    CanonicalAddress = x.CanonicalAddress,
                    CategorySlug = x.Category.Slug,
                    Description = x.Description,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    ShortDescription = x.ShortDescription,
                    Slug = x.Slug,
                    Title = x.Title
                }).FirstOrDefault(x => x.Slug == slug);

            if (!string.IsNullOrWhiteSpace(article.Keywords))
                article.KeywordList = article.Keywords.Split("،").ToList();

            var comments = _commentContext.Comments
                .Where(x => x.Type == CommentType.Article)
                .Where(x => x.OwnerRecordId == article.Id)
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Message = x.Message,
                    ParentId = x.ParentId,
                    CreationDate = x.CreationDate.ToFarsi()
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var comment in comments.Where(comment => comment.ParentId > 0))
            {
                comments.FirstOrDefault(x =>
                    x.Id == comment.ParentId)?.Children.Add(comment);
            }

            article.Comments = comments;

            return article;
        }

        public List<ArticleQueryModel> GetRelatedArticles(long categoryId)
        {
            return _context.Articles
                .Where(x => x.CategoryId == categoryId)
                .Include(x => x.Category)
                .Select(x => new ArticleQueryModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    CategoryName = x.Category.Name,
                    PublishDate = x.PublishDate.ToFarsi(),
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    ShortDescription = x.ShortDescription,
                }).OrderByDescending(x => x.Id).ToList();
        }

        public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles
                .Where(x => x.PublishDate <= DateTime.Now)
                .Include(x => x.Category)
                .Select(x => new ArticleQueryModel
                {
                    Id = x.Id,
                    CategoryName = x.Category.Name,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    ShortDescription = x.ShortDescription,
                    Slug = x.Slug,
                    Title = x.Title
                }).OrderByDescending(x=>x.Id).Take(6).ToList();
        }
    }
}
