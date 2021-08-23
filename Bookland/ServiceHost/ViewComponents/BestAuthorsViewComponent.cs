using _01_BooklandQuery.Contract.Author;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BestAuthorsViewComponent : ViewComponent
    {
        private readonly IAuthorQuery _authorQuery;

        public BestAuthorsViewComponent(IAuthorQuery authorQuery)
        {
            _authorQuery = authorQuery;
        }


        public IViewComponentResult Invoke(string type)
        {
            var bestAuthors = _authorQuery.GetBestAuthors();
            return View(type, bestAuthors);
        }
    }
}
