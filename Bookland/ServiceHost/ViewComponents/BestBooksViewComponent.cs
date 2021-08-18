using _01_BooklandQuery.Contract.Book;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BestBooksViewComponent : ViewComponent
    {
        private readonly IBookQuery _bookQuery;

        public BestBooksViewComponent(IBookQuery bookQuery)
        {
            _bookQuery = bookQuery;
        }


        public IViewComponentResult Invoke()
        {
            var bestBooks = _bookQuery.GetBestBooks();
            return View(bestBooks);
        }
    }
}
