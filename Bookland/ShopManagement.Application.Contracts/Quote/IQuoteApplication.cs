using System.Collections.Generic;
using _01_Framework.Application;

namespace ShopManagement.Application.Contracts.Quote
{
    public interface IQuoteApplication
    {
        OperationResult Create(CreateQuote command);
        OperationResult Edit(EditQuote command);
        OperationResult Remove(long id);
        OperationResult Restore(long id);
        EditQuote GetDetails(long id);
        List<QuoteViewModel> Search(QuoteSearchModel searchModel);
    }
}
