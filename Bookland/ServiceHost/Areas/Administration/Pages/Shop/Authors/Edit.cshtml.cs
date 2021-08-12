using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Author;

namespace ServiceHost.Areas.Administration.Pages.Shop.Authors
{
    public class EditModel : PageModel
    {
        public EditAuthor Command;

        private readonly IAuthorApplication _authorApplication;
        public EditModel(IAuthorApplication authorApplication)
        {
            _authorApplication = authorApplication;
        }


        public void OnGet(long id)
        {
            Command = _authorApplication.GetDetails(id);
        }

        public IActionResult OnPost(EditAuthor command)
        {
            _authorApplication.Edit(command);
            return RedirectToPage("./Index");
        }
    }
}
