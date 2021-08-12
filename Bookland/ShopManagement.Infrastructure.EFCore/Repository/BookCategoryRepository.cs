using System.Collections.Generic;
using System.Linq;
using _01_Framework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Application.Contracts.BookCategory;
using ShopManagement.Domain.BookCategoryAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class BookCategoryRepository : RepositoryBase<long, BookCategory>, IBookCategoryRepository
    {
        private readonly ShopContext _context;
        public BookCategoryRepository(ShopContext context) : base(context)
        {
            _context = context;
        }

        public List<BookCategoryDto> GetDetails(long bookId)
        {
            return _context.BookCategories.Where(x => x.BookId == bookId)
                .Select(x => new BookCategoryDto
                {
                    BookId = x.BookId,
                    CategoryId = x.CategoryId
                }).ToList();
        }

        public List<BookCategory> GetCategoriesByBookId(long bookId)
        {
            return _context.BookCategories.Where(x => x.BookId == bookId).ToList();
        }

        public void DeleteBookCategories(BookCategory bookCategory)
        {
            _context.BookCategories.Remove(bookCategory);
        }
    }
}
