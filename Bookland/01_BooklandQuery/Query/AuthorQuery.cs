using System;
using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Author;
using _01_BooklandQuery.Contract.Book;
using _01_BooklandQuery.Contract.BookCategory;
using _01_Framework.Application;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.BookAgg;
using ShopManagement.Domain.BookCategoryAgg;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class AuthorQuery : IAuthorQuery
    {
        private readonly ShopContext _shopContext;
        private readonly DiscountContext _discountContext;
        private readonly InventoryContext _inventoryContext;

        public AuthorQuery(ShopContext shopContext, DiscountContext discountContext, InventoryContext inventoryContext)
        {
            _shopContext = shopContext;
            _discountContext = discountContext;
            _inventoryContext = inventoryContext;
        }


        public List<AuthorQueryModel> GetAllAuthors()
        {
            return _shopContext.Authors
                .Include(x => x.Books)
                .Select(x => new AuthorQueryModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    BooksCount = x.Books.Count,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug
                }).OrderByDescending(x=>x.BooksCount).ToList();
        }

        public AuthorQueryModel GetAuthorDetails(string authorSlug)
        {
            var inventory = _inventoryContext.Inventory
                .Select(x => new { x.BookId, x.UnitPrice, x.InStock }).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.BookId, x.DiscountRate, x.EndDate });

            var author = _shopContext.Authors
                .Include(x => x.Books)
                .ThenInclude(x => x.BookCategories)
                .ThenInclude(x => x.Category)
                .Select(x => new AuthorQueryModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Books = MapBooks(x.Id, x.Books),
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Slug = x.Slug,
                    Biography = x.Biography,
                    BooksCount = x.Books.Count
                }).FirstOrDefault(x => x.Slug == authorSlug);

            foreach (var book in author.Books)
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

            return author;
        }


        public List<AuthorQueryModel> GetBestAuthors()
        {
            return _shopContext.Authors
                .Include(x => x.Books)
                .Select(x => new AuthorQueryModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    BooksCount = x.Books.Count,
                    Slug = x.Slug
                }).OrderByDescending(x => x.BooksCount).Take(10).ToList();
        }

        private static List<BookQueryModel> MapBooks(long authorId, List<Book> books)
        {
            return books.Where(x => x.AuthorId == authorId)
                .Select(x => new BookQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Categories = MapCategories(x.Id, x.BookCategories),
                }).ToList();
        }

        private static List<CategoryQueryModel> MapCategories(long bookId, List<BookCategory> bookCategories)
        {
            return bookCategories
                .Where(x => x.BookId == bookId)
                .Select(x => new CategoryQueryModel
                {
                    Id = x.CategoryId,
                    Name = x.Category.Name,
                    Slug = x.Category.Slug
                }).ToList();
        }

    }
}
