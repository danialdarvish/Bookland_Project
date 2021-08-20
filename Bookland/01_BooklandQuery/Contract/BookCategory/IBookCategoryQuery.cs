using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.BookCategory
{
    public interface IBookCategoryQuery
    {
        BookCategoryQueryModel GetBookCategoryWithBookBy(long id);
        List<BookCategoryQueryModel> GetBookCategories();
        List<BookCategoryQueryModel> GetBookCategoriesWithBooks();
    }
}