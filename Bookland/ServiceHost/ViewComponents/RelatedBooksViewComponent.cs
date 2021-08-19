using System.Collections.Generic;
using _01_BooklandQuery.Contract.Book;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class RelatedBooksViewComponent : ViewComponent
    {
        private readonly IBookQuery _bookQuery;

        public RelatedBooksViewComponent(IBookQuery bookQuery)
        {
            _bookQuery = bookQuery;
        }

        public IViewComponentResult Invoke(List<long> categoryId, long id)
        {
            var relatedBooks = _bookQuery.GetRelatedBooks(categoryId, id);
            return View(relatedBooks);
        }
    }
}
