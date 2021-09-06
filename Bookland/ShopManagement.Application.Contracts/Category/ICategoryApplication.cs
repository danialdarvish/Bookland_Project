using System.Collections.Generic;
using _01_Framework.Application;

namespace ShopManagement.Application.Contracts.Category
{
    public interface ICategoryApplication
    {
        OperationResult Create(CreateCategory command);
        OperationResult Edit(EditCategory command);
        EditCategory GetDetails(long id);
        List<CategoryViewModel> Search(CategorySearchModel searchModel, bool isParent);
        List<CategoryViewModel> GetCategories(); 
        List<CategoryViewModel> GetSubCategories();
        List<CategoryViewModel> GetMainCategories();
        List<CategoryViewModel> GetBookCategoriesBy(long bookId);
    }
}
