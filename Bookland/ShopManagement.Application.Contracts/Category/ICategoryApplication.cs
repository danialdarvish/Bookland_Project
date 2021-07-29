using System.Collections.Generic;
using _01_Framework.Application;

namespace ShopManagement.Application.Contracts.Category
{
    public interface ICategoryApplication
    {
        OperationResult Create(CreateCategory command);
        OperationResult Edit(EditCategory command);
        EditCategory GetDetails(long id);
        List<CategoryViewModel> Search(CategorySearchModel searchModel);
    }
}
