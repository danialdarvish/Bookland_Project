using _01_Framework.Application;

namespace ShopManagement.Application.Contracts.BookCategory
{
    public interface IBookCategoryApplication
    {
        OperationResult Create(BookCategoryDto command);
        OperationResult RemoveCategoryByBookId(long bookId);

    }
}
