using System;
using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using ShopManagement.Application.Contracts.Quote;
using ShopManagement.Domain.QuoteAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class QuoteRepository : RepositoryBase<long, Quote>, IQuoteRepository
    {
        private readonly ShopContext _context;
        public QuoteRepository(ShopContext context) : base(context)
        {
            _context = context;
        }


        public EditQuote GetDetails(long id)
        {
            return _context.Quotes.Select(x => new EditQuote
            {
                Id = x.Id,
                Text = x.Text,
                PersonName = x.PersonName,
                PersonPost = x.PersonPost,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<QuoteViewModel> Search(QuoteSearchModel searchModel)
        {
            var query = _context.Quotes.Select(x => new QuoteViewModel
            {
                Id = x.Id,
                Text = x.Text,
                PersonName = x.PersonName,
                PersonPost = x.PersonPost,
                PersonPicture = x.PersonPicture,
                IsRemoved = x.IsRemoved,
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.PersonName))
                query = query.Where(x => x.PersonName.Contains(searchModel.PersonName));

            return query.ToList();
        }
    }
}
