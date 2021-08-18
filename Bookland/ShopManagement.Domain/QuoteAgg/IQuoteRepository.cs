using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Application.Contracts.Quote;

namespace ShopManagement.Domain.QuoteAgg
{
    public interface IQuoteRepository : IRepository<long, Quote>
    {
        EditQuote GetDetails(long id);
        List<QuoteViewModel> Search(QuoteSearchModel searchModel);
    }
}
