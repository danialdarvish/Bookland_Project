using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Category;

namespace ServiceHost.Areas.Administration.Pages.Shop.Categories
{
    public class IndexModel : PageModel
    {
        public CategorySearchModel SearchModel;
        public List<CategoryViewModel> Categories;
        private readonly ICategoryApplication _categoryApplication;

        public IndexModel(ICategoryApplication categoryApplication)
        {
            _categoryApplication = categoryApplication;
        }

        public void OnGet(CategorySearchModel searchModel)
        {
            Categories = _categoryApplication.Search(searchModel);
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateCategory
            {
                Categories = _categoryApplication.GetMainCategories()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateCategory command)
        {
            var result = _categoryApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var category = _categoryApplication.GetDetails(id);
            category.Categories = _categoryApplication.GetMainCategories();
            return Partial("Edit", category);
        }

        public JsonResult OnPostEdit(EditCategory command)
        {
            var result = _categoryApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
