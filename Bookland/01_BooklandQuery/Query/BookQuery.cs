using System;
using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Book;
using _01_BooklandQuery.Contract.Comment;
using _01_Framework.Application;
using CommentManagement.Infrastructure.EFCore;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.BookCategoryAgg;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class BookQuery : IBookQuery
    {
        private readonly ShopContext _context;
        private readonly CommentContext _commentContext;
        private readonly DiscountContext _discountContext;
        private readonly InventoryContext _inventoryContext;

        public BookQuery(ShopContext context, DiscountContext discountContext,
            InventoryContext inventoryContext, CommentContext commentContext)
        {
            _context = context;
            _discountContext = discountContext;
            _inventoryContext = inventoryContext;
            _commentContext = commentContext;
        }


        public BookQueryModel GetBookDetails(string slug)
        {
            var inventory = _inventoryContext.Inventory
                .Select(x => new { x.BookId, x.UnitPrice, x.InStock }).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.BookId, x.DiscountRate, x.EndDate });

            var book = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookCategories)
                .ThenInclude(x => x.Category)
                .Select(x => new BookQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    AuthorName = x.Author.FullName,
                    Description = x.Description,
                    PageCount = x.PageCount,
                    Publisher = x.Publisher,
                    Language = x.Language,
                    Format = x.Format,
                    PublishDate = x.PublishDate.ToFarsi(),
                    Isbn = x.Isbn,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Keywords = x.Keywords,
                    MetaDescription = x.MetaDescription,
                    ShortDescription = x.ShortDescription,
                    Slug = x.Slug,
                    IsEditorsChoice = x.IsEditorsChoice,
                    CategoryId = MapCategoryId(x.Id, x.BookCategories),
                    CategoryNames = MapCategoryNames(x.Id, x.BookCategories)
                })
                .FirstOrDefault(x => x.Slug == slug);

            if (book == null) return new BookQueryModel();

            var bookInventory = inventory
                .FirstOrDefault(x => x.BookId == book.Id);
            if (bookInventory != null)
            {
                book.IsInStock = bookInventory.InStock;
                var price = bookInventory.UnitPrice;
                book.Price = price.ToMoney();
                book.DoublePrice = price;

                var discount = discounts
                    .FirstOrDefault(x => x.BookId == book.Id);
                if (discount != null)
                {
                    var discountRate = discount.DiscountRate;
                    book.DiscountRate = discountRate;
                    book.DiscountExpireDate = discount.EndDate.ToDiscountFormat();
                    book.HasDiscount = discountRate > 0;

                    var discountAmount = Math.Round(price * discountRate / 100);
                    book.PriceWithDiscount = (price - discountAmount).ToMoney();
                    book.DiscountPrice = discountAmount.ToMoney();
                }
            }

            var comments = _commentContext.Comments
                .Where(x => x.Type == CommentType.Book)
                .Where(x => x.OwnerRecordId == book.Id)
                .Where(x => !x.IsCanceled)
                .Where(x => x.IsConfirmed)
                .Select(x => new CommentQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Message = x.Message,
                    ParentId = x.ParentId,
                    CreationDate = x.CreationDate.ToFarsi()
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var comment in comments.Where(comment => comment.ParentId > 0))
            {
                comments.FirstOrDefault(x =>
                    x.Id == comment.ParentId)?.Children.Add(comment);
            }

            book.Comments = comments;

            return book;
        }

        public List<BookQueryModel> GetBestBooks()
        {
            var inventory = _inventoryContext.Inventory
                .Select(x => new { x.BookId, x.UnitPrice, x.InStock }).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.BookId, x.DiscountRate, x.EndDate });

            var bestBooks = _context.Books
                .Where(x => x.IsEditorsChoice)
                .Include(x => x.Author)
                .Include(x => x.BookCategories)
                .ThenInclude(x => x.Category)
                .Select(x => new BookQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PageCount = x.PageCount,
                    CategoryId = MapCategoryId(x.Id, x.BookCategories),
                    CategoryNames = MapCategoryNames(x.Id, x.BookCategories),
                    AuthorName = x.Author.FullName,
                    ShortDescription = x.ShortDescription,
                    IsEditorsChoice = x.IsEditorsChoice
                }).AsNoTracking()
                .AsEnumerable()
                .Shuffle()
                .Take(6)
                .OrderByDescending(x => x.Id)
                .ToList();


            foreach (var book in bestBooks)
            {
                var bookInventory = inventory
                    .FirstOrDefault(x => x.BookId == book.Id);
                if (bookInventory != null)
                {
                    var price = bookInventory.UnitPrice;
                    book.Price = price.ToMoney();
                    book.IsInStock = bookInventory.InStock;

                    var discount = discounts
                        .FirstOrDefault(x => x.BookId == book.Id);

                    if (discount != null)
                    {
                        var discountRate = discount.DiscountRate;
                        book.DiscountRate = discountRate;
                        book.HasDiscount = discountRate > 0;

                        var discountAmount = Math.Round(price * discountRate / 100);
                        book.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }

            return bestBooks;
        }

        public List<BookQueryModel> GetRelatedBooks(List<long> categoryId, long bookId)
        {
            var inventory = _inventoryContext.Inventory
                .Select(x => new { x.BookId, x.UnitPrice, x.InStock }).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.BookId, x.DiscountRate, x.EndDate });

            var books = _context.Books
                .Include(x => x.Author)
                .Include(x => x.BookCategories)
                .ThenInclude(x => x.Category)
                .AsNoTracking()
                .ToList();

            foreach (var book in books)
            {
                foreach (var category in categoryId)
                {
                    var relatedBookId = book.BookCategories
                        .FirstOrDefault(x => x.CategoryId == category)?.BookId;
                    if (relatedBookId > 0 && relatedBookId != bookId)
                        books = books.Where(x => x.Id == relatedBookId).ToList();
                }
            }

            var relatedBooks = books
                .Select(x => new BookQueryModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Slug = x.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PageCount = x.PageCount,
                    CategoryId = MapCategoryId(x.Id, x.BookCategories),
                    CategoryNames = MapCategoryNames(x.Id, x.BookCategories),
                    AuthorName = x.Author.FullName,
                    ShortDescription = x.ShortDescription,
                    IsEditorsChoice = x.IsEditorsChoice
                }).Shuffle().Take(6).ToList();

            foreach (var book in relatedBooks)
            {
                var bookInventory = inventory
                    .FirstOrDefault(x => x.BookId == book.Id);
                if (bookInventory != null)
                {
                    var price = bookInventory.UnitPrice;
                    book.Price = price.ToMoney();
                    book.IsInStock = bookInventory.InStock;

                    var discount = discounts
                        .FirstOrDefault(x => x.BookId == book.Id);

                    if (discount != null)
                    {
                        var discountRate = discount.DiscountRate;
                        book.DiscountRate = discountRate;
                        book.HasDiscount = discountRate > 0;

                        var discountAmount = Math.Round(price * discountRate / 100);
                        book.PriceWithDiscount = (price - discountAmount).ToMoney();
                    }
                }
            }

            return relatedBooks;
        }

        private static List<string> MapCategoryNames(long bookId, List<BookCategory> bookCategories)
        {
            return bookCategories.Where(x => x.BookId == bookId)
                .Select(x => x.Category.Name).ToList();
        }

        private static List<long> MapCategoryId(long bookId, List<BookCategory> bookCategories)
        {
            return bookCategories.Where(x => x.BookId == bookId)
                .Select(x => x.Category.Id).ToList();
        }

        public List<BookQueryModel> GetLatestArrivals()
        {
            throw new NotImplementedException();
        }

        public List<BookQueryModel> Search(string value)
        {
            throw new NotImplementedException();
        }
    }
}
