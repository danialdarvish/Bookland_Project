using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Author;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class AuthorQuery : IAuthorQuery
    {
        private readonly ShopContext _shopContext;

        public AuthorQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }


        public AuthorQueryModel GetAuthorDetails()
        {
            throw new System.NotImplementedException();
        }

        public List<AuthorQueryModel> GetBestAuthors()
        {
            return _shopContext.Authors
                .Include(x => x.Books)
                .Select(x => new AuthorQueryModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    BooksCount = x.Books.Count,
                    Slug = x.Slug
                }).OrderByDescending(x => x.BooksCount).Take(10).ToList();
        }
    }
}
