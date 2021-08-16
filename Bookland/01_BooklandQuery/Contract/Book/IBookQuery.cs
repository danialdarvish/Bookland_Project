using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.Book
{
    public interface IBookQuery
    {
        BookQueryModel GetBookDetails(string slug);
        List<BookQueryModel> GetLatestArrivals();
        List<BookQueryModel> Search(string value);
        //List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}
