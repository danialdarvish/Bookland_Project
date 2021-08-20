using System;
using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Book;
using _01_BooklandQuery.Contract.BookCategory;
using _01_Framework.Application;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.BookCategory;
using ShopManagement.Domain.BookCategoryAgg;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class BookCategoryQuery : IBookCategoryQuery
    {
        private readonly ShopContext _context;
        private readonly InventoryContext _inventoryContext;
        private readonly DiscountContext _discountContext;
        public BookCategoryQuery(ShopContext context, InventoryContext inventoryContext,
            DiscountContext discountContext)
        {
            _context = context;
            _inventoryContext = inventoryContext;
            _discountContext = discountContext;
        }


        public BookCategoryQueryModel GetBookCategoryWithBookBy(string slug)
        {
            var inventory = _inventoryContext.Inventory
                .Select(x => new { x.BookId, x.UnitPrice, x.InStock }).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.BookId, x.DiscountRate, x.EndDate });

            var category = _context.Categories
                .Select(x => new BookCategoryQueryModel
                {
                    Id = x.Id,
                    Slug = x.Slug,
                    Description = x.Description,
                    MetaDescription = x.MetaDescription,
                    Keywords = x.Keywords,
                    Name = x.Name,
                }).FirstOrDefault(x => x.Slug == slug);

            var books = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookCategories)
                .ThenInclude(x => x.Category)
                .Select(x => new BookQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Picture = x.Picture,
                    CategoryNames = MapCategoryNames(x.Id, x.BookCategories),
                    CategoryId = MapCategoryId(x.Id, x.BookCategories),
                    AuthorName = x.Author.FullName,
                    Slug = x.Slug
                }).ToList();

            foreach (var book in books.Where(book => book.CategoryId.Contains(category.Id)))
            {
                category?.Books.Add(book);
            }

            foreach (var book in category.Books)
            {
                var bookInventory = inventory
                    .FirstOrDefault(x => x.BookId == book.Id);
                if (bookInventory != null)
                {
                    var price = bookInventory.UnitPrice;
                    book.IsInStock = bookInventory.InStock;
                    book.Price = price.ToMoney();

                    var discount = discounts
                        .FirstOrDefault(x => x.BookId == book.Id);

                    if (discount != null)
                    {
                        var discountRate = discount.DiscountRate;
                        book.DiscountRate = discountRate;
                        book.DiscountExpireDate = discount.EndDate.ToDiscountFormat();
                        book.HasDiscount = discountRate > 0;

                        var discountAmount = Math.Round((price * discountRate) / 100);
                        book.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }

            return category;
        }

        private static List<string> MapCategoryNames(long id, List<BookCategory> bookCategories)
        {
            return bookCategories.Where(x => x.BookId == id)
                .Select(x => x.Category.Name).ToList();
        }

        private static List<long> MapCategoryId(long id, List<BookCategory> bookCategories)
        {
            return bookCategories.Where(x => x.BookId == id)
                .Select(x => x.Category.Id).ToList();
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
