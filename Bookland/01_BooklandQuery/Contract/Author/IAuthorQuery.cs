using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.Author
{
    public interface IAuthorQuery
    {
        AuthorQueryModel GetAuthorDetails(string authorSlug);
        List<AuthorQueryModel> GetBestAuthors();
    }
}
