using _01_BooklandQuery.Contract.Book;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class BookDetailModel : PageModel
    {
        public BookQueryModel Book;
        private readonly IBookQuery _bookQuery;
        private readonly ICommentApplication _commentApplication;

        public BookDetailModel(IBookQuery bookQuery, ICommentApplication commentApplication)
        {
            _bookQuery = bookQuery;
            _commentApplication = commentApplication;
        }

        public void OnGet(string id)
        {
            Book = _bookQuery.GetBookDetails(id);
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
