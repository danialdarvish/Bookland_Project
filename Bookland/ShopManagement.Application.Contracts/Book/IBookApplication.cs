using System.Collections.Generic;
using _01_Framework.Application;

namespace ShopManagement.Application.Contracts.Book
{
    public interface IBookApplication
    {
        OperationResult Create(CreateBook command);
        OperationResult Edit(EditBook command);
        EditBook GetDetails(long id);
        List<BookViewModel> Search(BookSearchModel searchModel);
        List<BookViewModel> GetBooks();
        long GetLastBookId();
    }
}
