using _01_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Author;
using ShopManagement.Application.Contracts.Book;
using ShopManagement.Application.Contracts.BookCategory;
using ShopManagement.Application.Contracts.Category;
using ShopManagement.Configuration.Permissions;

namespace ServiceHost.Areas.Administration.Pages.Shop.Books
{
    public class EditModel : PageModel
    {
        public SelectList Categories;
        public EditBook Command;
        public SelectList Authors;

        private readonly IBookApplication _bookApplication;
        private readonly IAuthorApplication _authorApplication;
        private readonly ICategoryApplication _categoryApplication;
        private readonly IBookCategoryApplication _bookCategoryApplication;
        public EditModel(IBookApplication bookApplication, ICategoryApplication categoryApplication, IBookCategoryApplication bookCategoryApplication, IAuthorApplication authorApplication)
        {
            _bookApplication = bookApplication;
            _authorApplication = authorApplication;
            _categoryApplication = categoryApplication;
            _bookCategoryApplication = bookCategoryApplication;
        }


        [NeedsPermission(ShopPermissions.EditBooks)]
        public void OnGet(long id)
        {
            Command = _bookApplication.GetDetails(id);
            Categories = new SelectList(_categoryApplication.GetSubCategories(),
                "Id", "Name");
            Authors = new SelectList(_authorApplication.ListAuthors(),
                "Id", "FullName");
        }

        public IActionResult OnPost(EditBook command)
        {
            if (ModelState.IsValid)
            {
                _bookApplication.Edit(command);
                _bookCategoryApplication.RemoveCategoryByBookId(command.Id);
                foreach (var item in command.CategoryId)
                {
                    var category = new BookCategoryDto
                    {
                        BookId = command.Id,
                        CategoryId = item
                    };
                    _bookCategoryApplication.Create(category);
                }
            }
           
            return RedirectToPage("./Index");
        }
    }
}
