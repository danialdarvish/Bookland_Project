using System.Collections.Generic;
using _01_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Book;
using ShopManagement.Application.Contracts.Category;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.Books
{
    public class IndexModel : PageModel
    {
        public BookSearchModel SearchModel;
        public List<BookViewModel> Books;

        private readonly IBookApplication _bookApplication;
        private readonly ICategoryApplication _categoryApplication;

        public IndexModel(IBookApplication bookApplication, ICategoryApplication categoryApplication)
        {
            _bookApplication = bookApplication;
            _categoryApplication = categoryApplication;
        }

        [NeedsPermission(ShopPermissions.ListBooks)]
        public void OnGet(BookSearchModel searchModel)
        {
            Books = _bookApplication.Search(searchModel);
        }

        [NeedsPermission(ShopPermissions.CreateBooks)]
        public IActionResult OnGetCreate()
        {
            var command = new CreateBook
            {
               Categories = _categoryApplication.GetSubCategories()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateBook command)
        {
            var result = _bookApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedsPermission(ShopPermissions.EditBooks)]
        public IActionResult OnGetEdit(long id)
        {
            var category = _bookApplication.GetDetails(id);
            category.Categories = _categoryApplication.GetSubCategories();
            return Partial("Edit", category);
        }

        public JsonResult OnPostEdit(EditBook command)
        {
            var result = _bookApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
