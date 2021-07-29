using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using ShopManagement.Application.Contracts.Category;
using ShopManagement.Domain.CategoryAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class CategoryRepository : RepositoryBase<long, Category>, ICategoryRepository
    {
        private readonly ShopContext _context;

        public CategoryRepository(ShopContext context) : base(context)
        {
            _context = context;
        }


        public EditCategory GetDetails(long id)
        {
            return _context.Categories.Select(x => new EditCategory
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                MetaDescription = x.MetaDescription,
                Keywords = x.Keywords,
                Slug = x.Slug
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CategoryViewModel> Search(CategorySearchModel searchModel)
        {
            var query = _context.Categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
