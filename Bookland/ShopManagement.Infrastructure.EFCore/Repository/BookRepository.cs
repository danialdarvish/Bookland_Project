using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.Book;
using ShopManagement.Domain.BookAgg;
using ShopManagement.Domain.BookCategoryAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class BookRepository : RepositoryBase<long, Book>, IBookRepository
    {
        private readonly ShopContext _context;
        public BookRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public EditBook GetDetails(long id)
        {
            return _context.Books.Select(x => new EditBook
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                MetaDescription = x.MetaDescription,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Format = x.Format,
                Isbn = x.Isbn,
                Language = x.Language,
                Publisher = x.Publisher,
                Slug = x.Slug,
                PublishDate = x.PublishDate.ToFarsi(),
                PageCount = x.PageCount,
                Keywords = x.Keywords, // Bug (include)
                AuthorId = x.AuthorId,
                ShortDescription = x.ShortDescription,
                IsEditorsChoice = x.IsEditorsChoice,
                CategoryId = MapCategories(x.BookCategories, x.Id)
            }).FirstOrDefault(x => x.Id == id);
        }

        private static List<long> MapCategories(List<BookCategory> bookCategories, long bookId)
        {
            return bookCategories
                .Where(x => x.BookId == bookId)
                .Select(x => x.CategoryId)
                .ToList();
        }

        public List<BookViewModel> Search(BookSearchModel searchModel)
        {
            var query = _context.Books
                .Include(x=>x.Author)
                .Include(x=> x.BookCategories)
                .ThenInclude(x=>x.Category)
                .Select(x => new BookViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Categories = MapCategoryNames(x.BookCategories),
                    AuthorName = x.Author.FullName,
                    Format = x.Format,
                    Language = x.Language,
                    PageCount = x.PageCount,
                    Picture = x.Picture,
                    Publisher = x.Publisher,
                    IsEditorsChoice = x.IsEditorsChoice,
                    PublishDate = x.PublishDate.ToFarsi(),
                    CreationDate = x.CreationDate.ToFarsi()
                });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));
            if (searchModel.CategoryId > 0)
                query = query.Where(x => x.CategoryId == searchModel.CategoryId);

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public List<BookViewModel> GetBooks()
        {
            return _context.Books.Select(x => new BookViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        private static List<string> MapCategoryNames(List<BookCategory> bookCategories)
        {
            return bookCategories.Select(x => x.Category.Name).ToList();
        }

        public long GetLastBookId()
        {
            return _context.Books.OrderBy(x=>x.Id).Last().Id;
        }
    }
}
