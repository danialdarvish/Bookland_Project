using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Author;

namespace ServiceHost.Areas.Administration.Pages.Shop.Authors
{
    public class IndexModel : PageModel
    {
        public AuthorSearchModel SearchModel;
        public List<AuthorViewModel> Authors;

        private readonly IAuthorApplication _authorApplication;

        public IndexModel(IAuthorApplication authorApplication)
        {
            _authorApplication = authorApplication;
        }

        public void OnGet(AuthorSearchModel searchModel)
        {
            Authors = _authorApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateAuthor();
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateAuthor command)
        {
            var result = _authorApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var category = _authorApplication.GetDetails(id);
            return Partial("Edit", category);
        }

        public JsonResult OnPostEdit(EditAuthor command)
        {
            var result = _authorApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
