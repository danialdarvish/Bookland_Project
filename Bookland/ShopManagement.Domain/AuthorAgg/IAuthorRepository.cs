using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Application.Contracts.Author;

namespace ShopManagement.Domain.AuthorAgg
{
    public interface IAuthorRepository : IRepository<long, Author>
    {
        EditAuthor GetDetails(long id);
        List<AuthorViewModel> Search(AuthorSearchModel searchModel);
        List<AuthorViewModel> ListAuthors();
    }
}
