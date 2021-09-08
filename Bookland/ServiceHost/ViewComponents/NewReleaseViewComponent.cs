using _01_BooklandQuery.Contract.Book;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class NewReleaseViewComponent : ViewComponent
    {
        private readonly IBookQuery _bookQuery;

        public NewReleaseViewComponent(IBookQuery bookQuery)
        {
            _bookQuery = bookQuery;
        }

        public IViewComponentResult Invoke()
        {
            var latestArrivals = _bookQuery.GetLatestArrivals();
            return View(latestArrivals);
        }
    }
}
