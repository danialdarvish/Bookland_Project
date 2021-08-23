using _01_BooklandQuery.Contract.Author;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AuthorDetailModel : PageModel
    {
        public AuthorQueryModel Author;

        private readonly IAuthorQuery _authorQuery;

        public AuthorDetailModel(IAuthorQuery authorQuery)
        {
            _authorQuery = authorQuery;
        }


        public void OnGet(string id)
        {
            Author = _authorQuery.GetAuthorDetails(id);
        }
    }
}
