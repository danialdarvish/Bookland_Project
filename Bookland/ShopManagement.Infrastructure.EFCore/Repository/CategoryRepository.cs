using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
                Slug = x.Slug,
                ParentId = x.ParentId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CategoryViewModel> Search(CategorySearchModel searchModel, bool isParent)
        {
            var query = _context.Categories
                .Where(x => isParent ? x.ParentId == 0 : x.ParentId > 0)
                .Select(x => new CategoryViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    CreationDate = x.CreationDate.ToFarsi(),
                    ParentCategory = MapParentCategory(x.ParentId, _context.Categories.ToList()),
                    ChildrenCount = CountChildren(x.Id, _context.Categories.ToList())
                });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            return query.OrderByDescending(x => x.Id).ToList();
        }

        private static long CountChildren(long id, List<Category> categories)
        {
            return categories.Count(x => x.ParentId == id);
        }

        private static string MapParentCategory(long parentId, List<Category> categories)
        {
            return categories.FirstOrDefault(x => x.Id == parentId)?.Name;
        }

        public List<CategoryViewModel> GetCategories()
        {
            return _context.Categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public List<CategoryViewModel> GetSubCategories()
        {
            return _context.Categories.Where(x => x.ParentId != 0)
                .Select(x => new CategoryViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
        }

        public List<CategoryViewModel> GetMainCategories()
        {
            return _context.Categories.Where(x => x.ParentId == 0)
                .Select(x => new CategoryViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
        }

        public List<CategoryViewModel> GetBookCategoriesBy(long id)
        {
            return _context.BookCategories
                .Include(x => x.Category)
                .Where(x => x.CategoryId == id)
                .Select(x => new CategoryViewModel
                {
                    Id = x.Category.Id,
                    Name = x.Category.Name
                }).ToList();
        }
    }
}
