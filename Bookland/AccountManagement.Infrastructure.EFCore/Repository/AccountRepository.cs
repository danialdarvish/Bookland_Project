using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;
using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Infrastructure.EFCore.Repository
{
    public class AccountRepository : RepositoryBase<long, Account>, IAccountRepository
    {
        private readonly AccountContext _context;
        public AccountRepository(AccountContext context) : base(context)
        {
            _context = context;
        }

        public Account GetByUsername(string username)
        {
            return _context.Accounts.FirstOrDefault(x => x.Username == username);
        }

        public EditAccount GetDetails(long id)
        {
            return _context.Accounts
                .Select(x => new EditAccount
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Mobile = x.Mobile,
                    Username = x.Username,
                    RoleId = x.RoleId
                }).FirstOrDefault(x => x.Id == id);
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            var query = _context.Accounts
                .Include(x => x.Role)
                .Select(x => new AccountViewModel
                {
                    Id = x.Id,
                    FullName = x.FullName,
                    Username = x.Username,
                    Mobile = x.Mobile,
                    CreationDate = x.CreationDate.ToFarsi(),
                    Role = x.Role.Name
                });

            if (!string.IsNullOrWhiteSpace(searchModel.FullName))
                query = query.Where(x => x.FullName.Contains(searchModel.FullName));
            if (!string.IsNullOrWhiteSpace(searchModel.Mobile))
                query = query.Where(x => x.Mobile.Contains(searchModel.Mobile));
            if (!string.IsNullOrWhiteSpace(searchModel.Username))
                query = query.Where(x => x.Username.Contains(searchModel.Username));
            if (searchModel.RoleId > 0)
                query = query.Where(x => x.RoleId == searchModel.RoleId);

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
