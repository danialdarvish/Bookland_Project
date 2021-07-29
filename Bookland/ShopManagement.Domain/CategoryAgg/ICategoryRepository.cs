using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Application.Contracts.Category;

namespace ShopManagement.Domain.CategoryAgg
{
    public interface ICategoryRepository : IRepository<long, Category>
    {
        EditCategory GetDetails(long id);
        List<CategoryViewModel> Search(CategorySearchModel searchModel);
    }
}
