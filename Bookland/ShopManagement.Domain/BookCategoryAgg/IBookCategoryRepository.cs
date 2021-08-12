using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Application.Contracts.BookCategory;

namespace ShopManagement.Domain.BookCategoryAgg
{
    public interface IBookCategoryRepository : IRepository<long, BookCategory>
    {
        List<BookCategoryDto> GetDetails(long bookId);
        List<BookCategory> GetCategoriesByBookId(long bookId);
        void DeleteBookCategories(BookCategory bookCategory);
    }
}
