using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Quote;

namespace ServiceHost.Areas.Administration.Pages.Shop.Quotes
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public QuoteSearchModel SearchModel;
        public List<QuoteViewModel> Quotes;

        private readonly IQuoteApplication _quoteApplication;
        public IndexModel(IQuoteApplication quoteApplication)
        {
            _quoteApplication = quoteApplication;
        }


        public void OnGet(QuoteSearchModel searchModel)
        {
            Quotes = _quoteApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateQuote();
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateQuote command)
        {
            var result = _quoteApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var quote = _quoteApplication.GetDetails(id);
            return Partial("Edit", quote);
        }

        public JsonResult OnPostEdit(EditQuote command)
        {
            var result = _quoteApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _quoteApplication.Remove(id);
            Message = result.Message;
            if (result.IsSucceed)
                return RedirectToPage("./Index");
            
            return RedirectToPage("./Index");

        }

        public IActionResult OnGetRestore(long id)
        {
            var result = _quoteApplication.Restore(id);
            Message = result.Message;
            if (result.IsSucceed)
                return RedirectToPage("./Index");

            return RedirectToPage("./Index");
        }
    }
}
