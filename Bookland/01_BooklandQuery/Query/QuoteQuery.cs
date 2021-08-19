using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using _01_BooklandQuery.Contract.Quote;
using _01_Framework.Application;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class QuoteQuery : IQuoteQuery
    {
        private readonly ShopContext _shopContext;

        public QuoteQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }


        public List<QuoteQueryModel> GetQuotes()
        {
            return _shopContext.Quotes.Select(x => new QuoteQueryModel
            {
                PersonName = x.PersonName,
                PersonPicture = x.PersonPicture,
                PersonPost = x.PersonPost,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Text = x.Text
            }).AsEnumerable().Shuffle().Take(5).ToList();
        }
    }
}
