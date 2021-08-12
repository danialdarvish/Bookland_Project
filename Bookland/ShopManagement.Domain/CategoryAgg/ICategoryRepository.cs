using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Application.Contracts.Category;

namespace ShopManagement.Domain.CategoryAgg
{
    public interface ICategoryRepository : IRepository<long, Category>
    {
        EditCategory GetDetails(long id);
        List<CategoryViewModel> Search(CategorySearchModel searchModel);
        List<CategoryViewModel> GetCategories(); 
        List<CategoryViewModel> GetSubCategories();
        List<CategoryViewModel> GetMainCategories();
        List<CategoryViewModel> GetBookCategoriesBy(long id);
    }
}
