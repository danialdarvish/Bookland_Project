using System.Linq;
using _01_BooklandQuery.Contract.Status;
using AccountManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class StatusQuery : IStatusQuery
    {
        private readonly ShopContext _shopContext;
        private readonly AccountContext _accountContext;

        public StatusQuery(ShopContext shopContext, AccountContext accountContext)
        {
            _shopContext = shopContext;
            _accountContext = accountContext;
        }


        public int GetAllBooksCount()
        {
            return _shopContext.Books.Count();
        }

        public int GetAllUsersCount()
        {
            return _accountContext.Accounts.Count();
        }

        public int GetHappyUsersCount()
        {
            return 340; // Magic Numbers
        }
    }
}
