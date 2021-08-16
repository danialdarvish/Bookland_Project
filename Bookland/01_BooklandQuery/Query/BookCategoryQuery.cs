using System;
using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.BookCategory;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class BookCategoryQuery : IBookCategoryQuery
    {
        private readonly ShopContext _context;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;
        public BookCategoryQuery(ShopContext context, InventoryContext inventoryContext, DiscountContext discountContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }


        public BookCategoryQueryModel GetBookCategoryWithBookBy(string slug)
        {
            throw new NotImplementedException();
        }

        public List<BookCategoryQueryModel> GetBookCategories()
        {
            var categories = _context.Categories
                .Select(x => new BookCategoryQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    ParentId = x.ParentId,
                }).ToList();

            foreach (var category in categories.Where(category => category.ParentId > 0))
            {
                categories.FirstOrDefault(x =>
                    x.Id == category.ParentId)?.Children.Add(category);
            }

            categories = categories.Where(x => x.ParentId == 0).ToList();
            return categories;
        }

        private static List<BookCategoryQueryModel> MapChildren(List<BookCategoryQueryModel> categories)
        {
            foreach (var category in categories)
            {
                if (category.ParentId > 0)
                {
                    categories.FirstOrDefault(x =>
                        x.Id == category.ParentId)?.Children.Add(category);
                }
            }

            return categories;
        }

        public List<BookCategoryQueryModel> GetBookCategoriesWithBooks()
        {
            throw new NotImplementedException();
        }
    }
}
