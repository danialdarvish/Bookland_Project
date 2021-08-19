using System;
    using System.Collections.Generic;
using _01_Framework.Application;
using ShopManagement.Application.Contracts.Book;
using ShopManagement.Domain.BookAgg;
using ShopManagement.Domain.CategoryAgg;

namespace ShopManagement.Application
{
    public class BookApplication : IBookApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly IBookRepository _bookRepository;

        public BookApplication(IBookRepository bookRepository, IFileUploader fileUploader, ICategoryRepository categoryRepository)
        {
            _fileUploader = fileUploader;
            _bookRepository = bookRepository;
        }


        public OperationResult Create(CreateBook command)
        {
            var operation = new OperationResult();
            if (_bookRepository.Exists(x => x.Isbn == command.Isbn))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var pictureName = _fileUploader.Upload(command.Picture, "Books");
            var slug = command.Slug.Slugify();
            var publishDate = command.PublishDate.ToGeorgianDateTime();
            var book = new Book(command.Name, command.Format, command.PageCount, publishDate, 
                command.Publisher, command.Language, command.Isbn, pictureName, command.PictureAlt,
                command.PictureTitle, slug, command.Keywords, command.MetaDescription,
                command.Description, command.AuthorId, command.ShortDescription, command.IsEditorsChoice);
            
            _bookRepository.Create(book);
            _bookRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Edit(EditBook command)
        {
            var operation = new OperationResult();

            var book = _bookRepository.Get(command.Id);

            if (book == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_bookRepository.Exists(x => x.Isbn == command.Isbn && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var pictureName = _fileUploader.Upload(command.Picture, "Books");
            var slug = command.Slug.Slugify();
            var publishDate = command.PublishDate.ToGeorgianDateTime();
            book.Edit(command.Name, command.Format, command.PageCount, publishDate,
                command.Publisher, command.Language, command.Isbn, pictureName, command.PictureAlt,
                command.PictureTitle, slug, command.Keywords, command.MetaDescription,
                command.Description, command.AuthorId, command.ShortDescription, command.IsEditorsChoice);

            _bookRepository.SaveChanges();

            return operation.Succeed();
        }

        public EditBook GetDetails(long id)
        {
            return _bookRepository.GetDetails(id);
        }

        public List<BookViewModel> Search(BookSearchModel searchModel)
        {
            return _bookRepository.Search(searchModel);
        }

        public List<BookViewModel> GetBooks()
        {
            return _bookRepository.GetBooks();
        }

        public long GetLastBookId()
        {
            return _bookRepository.GetLastBookId();
        }
    }
}
