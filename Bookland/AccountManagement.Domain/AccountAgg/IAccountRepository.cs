using System.Collections.Generic;
using _01_Framework.Domain;
using AccountManagement.Application.Contracts.Account;

namespace AccountManagement.Domain.AccountAgg
{
    public interface IAccountRepository : IRepository<long, Account>
    {
        Account GetByUsername(string username);
        EditAccount GetDetails(long id);
        List<AccountViewModel> GetAccounts();
        List<AccountViewModel> Search(AccountSearchModel searchModel);
    }
}
