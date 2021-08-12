using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using ShopManagement.Application.Contracts.Author;
using ShopManagement.Domain.AuthorAgg;

namespace ShopManagement.Infrastructure.EFCore.Repository
{
    public class AuthorRepository : RepositoryBase<long, Author>, IAuthorRepository
    {
        private readonly ShopContext _context;
        public AuthorRepository(ShopContext context) : base(context)
        {
            _context = context;
        }


        public EditAuthor GetDetails(long id)
        {
            return _context.Authors.Select(x => new EditAuthor
            {
                Id = x.Id,
                FullName = x.FullName,
                Biography = x.Biography,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Slug = x.Slug,
                MetaDescription = x.MetaDescription
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<AuthorViewModel> Search(AuthorSearchModel searchModel)
        {
            var query = _context.Authors.Select(x => new AuthorViewModel
            {
                Id = x.Id,
                FullName = x.FullName,
                Picture = x.FullName,
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.FullName))
                query = query.Where(x => x.FullName.Contains(searchModel.FullName));

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public List<AuthorViewModel> ListAuthors()
        {
            return _context.Authors.Select(x => new AuthorViewModel
            {
                Id = x.Id,
                FullName = x.FullName
            })
                .OrderByDescending(x => x.FullName)
                .ToList();
        }
    }
}
