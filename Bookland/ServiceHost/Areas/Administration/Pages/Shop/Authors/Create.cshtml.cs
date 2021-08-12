using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Author;

namespace ServiceHost.Areas.Administration.Pages.Shop.Authors
{
    public class CreateModel : PageModel
    {
        public CreateAuthor Command;

        private readonly IAuthorApplication _authorApplication;
        public CreateModel(IAuthorApplication authorApplication)
        {
            _authorApplication = authorApplication;
        }


        public void OnGet()
        {
           
        }

        public IActionResult OnPost(CreateAuthor command)
        {
            _authorApplication.Create(command);
            return RedirectToPage("./Index");
        }
    }
}
