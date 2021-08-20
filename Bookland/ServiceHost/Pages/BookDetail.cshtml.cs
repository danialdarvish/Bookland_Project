using System.Collections.Generic;
using _01_BooklandQuery.Contract.Article;
using _01_BooklandQuery.Contract.Author;
using _01_BooklandQuery.Contract.Book;
using _01_BooklandQuery.Contract.BookCategoryCount;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class BookDetailModel : PageModel
    {
        public BookQueryModel Book;
        public List<AuthorQueryModel> Authors;
        public List<ArticleQueryModel> LatestArticles;
        public List<BookCategoryCountQueryModel> BookCategories;

        private readonly IBookQuery _bookQuery;
        private readonly IAuthorQuery _authorQuery;
        private readonly IArticleQuery _articleQuery;
        private readonly ICommentApplication _commentApplication;
        private readonly IBookCategoryCountQuery _bookCategoryCountQuery;

        public BookDetailModel(IBookQuery bookQuery, ICommentApplication commentApplication, IBookCategoryCountQuery bookCategoryCountQuery, IArticleQuery articleQuery, IAuthorQuery authorQuery)
        {
            _bookQuery = bookQuery;
            _authorQuery = authorQuery;
            _articleQuery = articleQuery;
            _commentApplication = commentApplication;
            _bookCategoryCountQuery = bookCategoryCountQuery;
        }

        public void OnGet(string id)
        {
            Book = _bookQuery.GetBookDetails(id);
            BookCategories = _bookCategoryCountQuery.GetSubCategoriesWithBookCount();
            LatestArticles = _articleQuery.LatestArticles();
            Authors = _authorQuery.GetBestAuthors();
        }

        public IActionResult OnPost(AddComment command, string bookSlug)
        {
            command.Type = CommentType.Book;
            if (ModelState.IsValid)
            {
                _commentApplication.Add(command);
            }
            return RedirectToPage("/BookDetail", new { Id = bookSlug });
        }
    }
}
