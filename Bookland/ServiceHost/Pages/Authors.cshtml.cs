using System.Collections.Generic;
using _01_BooklandQuery.Contract.Author;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AuthorsModel : PageModel
    {
        public List<AuthorQueryModel> Authors;

        private readonly IAuthorQuery _authorQuery;

        public AuthorsModel(IAuthorQuery authorQuery)
        {
            _authorQuery = authorQuery;
        }

        public void OnGet()
        {
            Authors = _authorQuery.GetAllAuthors();
        }
    }
}
