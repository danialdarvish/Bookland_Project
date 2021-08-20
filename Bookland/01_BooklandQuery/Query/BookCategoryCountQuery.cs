using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.BookCategoryCount;
using _01_Framework.Application;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class BookCategoryCountQuery : IBookCategoryCountQuery
    {
        private readonly ShopContext _shopContext;

        public BookCategoryCountQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }


        public List<BookCategoryCountQueryModel> GetCounts()
        {
            var categories = _shopContext.Categories
                .Where(x=>x.ParentId == 0)
                .Select(x => new BookCategoryCountQueryModel
                {
                    Id = x.Id,
                    CategoryName = x.Name,
                }).ToList();

            foreach (var category in categories)
            {
                var subCategories = _shopContext.Categories
                    .Include(x=>x.BookCategories)
                    .Where(x => x.ParentId == category.Id).ToList();

                foreach (var subCategory in subCategories)
                {
                    category.BooksCount = subCategory.BookCategories.Count;
                }
            }


            return categories.OrderBy(x=>x.BooksCount)
                .Shuffle().Take(4).ToList();
        }
    }
}
