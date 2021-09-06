using _01_BooklandQuery.Contract.Book;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BestSellingViewComponent : ViewComponent
    {
        private readonly IBookQuery _bookQuery;

        public BestSellingViewComponent(IBookQuery bookQuery)
        {
            _bookQuery = bookQuery;
        }


        public IViewComponentResult Invoke()
        {
            var topSales = _bookQuery.TopSales();
            return View(topSales);
        }
    }
}
