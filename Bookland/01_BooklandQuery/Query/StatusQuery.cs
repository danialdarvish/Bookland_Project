using System.Linq;
using _01_BooklandQuery.Contract.Status;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class StatusQuery : IStatusQuery
    {
        private readonly ShopContext _shopContext;

        public StatusQuery(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }


        public int GetAllBooksCount()
        {
            return _shopContext.Books.Count();
        }

        public int GetAllUsersCount()
        {
            return 372; // Magic Numbers
        }

        public int GetHappyUsersCount()
        {
            return 340; // Magic Numbers
        }
    }
}
