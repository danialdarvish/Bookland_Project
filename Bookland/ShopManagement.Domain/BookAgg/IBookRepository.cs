using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Application.Contracts.Book;

namespace ShopManagement.Domain.BookAgg
{
    public interface IBookRepository : IRepository<long, Book>
    {
        EditBook GetDetails(long id);
        List<BookViewModel> Search(BookSearchModel searchModel);
        List<BookViewModel> GetBooks();
        long GetLastBookId();
    }
}
