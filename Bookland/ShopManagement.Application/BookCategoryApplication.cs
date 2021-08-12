using System.Linq;
using _01_Framework.Application;
using ShopManagement.Application.Contracts.BookCategory;
using ShopManagement.Domain.BookCategoryAgg;

namespace ShopManagement.Application
{
    public class BookCategoryApplication : IBookCategoryApplication
    {
        private readonly IBookCategoryRepository _bookCategoryRepository;

        public BookCategoryApplication(IBookCategoryRepository bookCategoryRepository)
        {
            _bookCategoryRepository = bookCategoryRepository;
        }


        public OperationResult Create(BookCategoryDto command)
        {
            var operation = new OperationResult();

            var bookCategory = new BookCategory(command.BookId, command.CategoryId);
            _bookCategoryRepository.Create(bookCategory);
            _bookCategoryRepository.SaveChanges();
            
            return operation.Succeed();
        }

        public OperationResult Edit(BookCategoryDto command)
        {
            var operation = new OperationResult();
            var bookCategories = _bookCategoryRepository.GetDetails(command.BookId);



            _bookCategoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult RemoveCategoryByBookId(long bookId)
        {
            _bookCategoryRepository.GetCategoriesByBookId(bookId).ToList()
                .ForEach(x=> _bookCategoryRepository.DeleteBookCategories(x));

            return new OperationResult().Succeed();
        }
    }
}
