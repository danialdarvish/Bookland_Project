using _01_BooklandQuery.Contract.Quote;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class QuoteViewComponent : ViewComponent
    {
        private readonly IQuoteQuery _quoteQuery;

        public QuoteViewComponent(IQuoteQuery quoteQuery)
        {
            _quoteQuery = quoteQuery;
        }

        public IViewComponentResult Invoke()
        {
            var quotes = _quoteQuery.GetQuotes();
            return View(quotes);
        }
    }
}
