using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.Quote
{
    public interface IQuoteQuery
    {
        List<QuoteQueryModel> GetQuotes();
    }
}
