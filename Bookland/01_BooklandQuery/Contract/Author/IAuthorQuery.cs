using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.Author
{
    public interface IAuthorQuery
    {
        AuthorQueryModel GetAuthorDetails();
        List<AuthorQueryModel> GetBestAuthors();
    }
}
