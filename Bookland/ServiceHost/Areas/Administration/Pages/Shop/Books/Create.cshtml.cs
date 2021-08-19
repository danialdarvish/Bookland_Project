using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Author;
using ShopManagement.Application.Contracts.Book;
using ShopManagement.Application.Contracts.BookCategory;
using ShopManagement.Application.Contracts.Category;

namespace ServiceHost.Areas.Administration.Pages.Shop.Books
{
    public class CreateModel : PageModel
    {
        public SelectList Categories;
        public SelectList Authors;
        public CreateBook Command;

        private readonly IBookApplication _bookApplication;
        private readonly IAuthorApplication _authorApplication;
        private readonly ICategoryApplication _categoryApplication;
        private readonly IBookCategoryApplication _bookCategoryApplication;
        public CreateModel(IBookApplication bookApplication, ICategoryApplication categoryApplication, IAuthorApplication authorApplication, IBookCategoryApplication bookCategoryApplication)
        {
            _bookApplication = bookApplication;
            _authorApplication = authorApplication;
            _bookCategoryApplication = bookCategoryApplication;
            _categoryApplication = categoryApplication;
        }


        public void OnGet()
        {
            Categories = new SelectList(_categoryApplication.GetSubCategories(),
                "Id", "Name");
            Authors = new SelectList(_authorApplication.ListAuthors(),
                "Id", "FullName");
        }

        public IActionResult OnPost(CreateBook command)
        {
            if (ModelState.IsValid)
            {
                _bookApplication.Create(command);
                foreach (var item in command.CategoryId)
                {
                    var category = new BookCategoryDto
                    {
                        CategoryId = item,
                        BookId = _bookApplication.GetLastBookId()
                    };
                    _bookCategoryApplication.Create(category);
                }
            }
            return RedirectToPage("./Index");
        }
    }
}

#region Model state debugging

//foreach (var modelState in ViewData.ModelState.Values)
//{
//    foreach (ModelError error in modelState.Errors)
//    {
//        error.ToString();
//    }
//}

#endregion
