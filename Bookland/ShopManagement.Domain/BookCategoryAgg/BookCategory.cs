using ShopManagement.Domain.BookAgg;
using ShopManagement.Domain.CategoryAgg;

namespace ShopManagement.Domain.BookCategoryAgg
{
    public class BookCategory
    {
        public long BookId { get; private set; }
        public Book Book { get; private set; }

        public long CategoryId { get; private set; }
        public Category Category { get; private set; }

        public BookCategory(long bookId, long categoryId)
        {
            BookId = bookId;
            CategoryId = categoryId;
        }
    }
}
