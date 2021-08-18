using System.Collections.Generic;
using _01_Framework.Application;
using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using ShopManagement.Application.Contracts.Quote;
using ShopManagement.Domain.QuoteAgg;

namespace ShopManagement.Application
{
    public class QuoteApplication : IQuoteApplication
    {
        private readonly IFileUploader _fileUploader;
        private readonly IQuoteRepository _quoteRepository;

        public QuoteApplication(IQuoteRepository quoteRepository, IFileUploader fileUploader)
        {
            _fileUploader = fileUploader;
            _quoteRepository = quoteRepository;
        }


        public OperationResult Create(CreateQuote command)
        {
            var operation = new OperationResult();

            if (_quoteRepository
                .Exists(x => x.PersonName == command.PersonName && x.Text == command.Text))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var pictureName = _fileUploader.Upload(command.PersonPicture, "Quotes");
            var quote = new Quote(command.PersonName, command.PersonPost, command.Text,
                pictureName, command.PictureAlt, command.PictureTitle);

            _quoteRepository.Create(quote);
            _quoteRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Edit(EditQuote command)
        {
            var operation = new OperationResult();
            var quote = _quoteRepository.Get(command.Id);

            if (quote == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (_quoteRepository
                .Exists(x => x.PersonName == command.PersonName && x.Text == command.Text
                                                                && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var pictureName = _fileUploader.Upload(command.PersonPicture, "Quotes");
            quote.Edit(command.PersonName, command.PersonPost, command.Text,
                pictureName, command.PictureAlt, command.PictureTitle);

            _quoteRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult Remove(long id)
        {
            var operation = new OperationResult();
            var quote = _quoteRepository.Get(id);
            if (quote == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            quote.Remove();

            _quoteRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var quote = _quoteRepository.Get(id);
            if (quote == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            quote.Restore();

            _quoteRepository.SaveChanges();
            return operation.Succeed();
        }

        public EditQuote GetDetails(long id)
        {
            return _quoteRepository.GetDetails(id);
        }

        public List<QuoteViewModel> Search(QuoteSearchModel searchModel)
        {
            return _quoteRepository.Search(searchModel);
        }
    }
}
