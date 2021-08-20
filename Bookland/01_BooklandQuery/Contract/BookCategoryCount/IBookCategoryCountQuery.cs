using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.BookCategoryCount
{
    public interface IBookCategoryCountQuery
    {
        List<BookCategoryCountQueryModel> GetMainCategoriesWithBookCount();
        List<BookCategoryCountQueryModel> GetSubCategoriesWithBookCount();
    }
}
