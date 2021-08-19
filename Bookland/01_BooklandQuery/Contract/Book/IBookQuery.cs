using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.Book
{
    public interface IBookQuery
    {
        BookQueryModel GetBookDetails(string slug);
        List<BookQueryModel> GetLatestArrivals();
        List<BookQueryModel> Search(string value);
        List<BookQueryModel> GetBestBooks();

        List<BookQueryModel> GetRelatedBooks(List<long> categoryId, long bookId);
        //List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}
