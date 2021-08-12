using System.Collections.Generic;
using _01_Framework.Application;

namespace ShopManagement.Application.Contracts.Author
{
    public interface IAuthorApplication
    {
        OperationResult Create(CreateAuthor command);
        OperationResult Edit(EditAuthor command);
        EditAuthor GetDetails(long id);
        List<AuthorViewModel> Search(AuthorSearchModel searchModel);
        List<AuthorViewModel> ListAuthors();
    }
}
