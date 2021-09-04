using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using _01_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.RoleAgg;

namespace AccountManagement.Application
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IAuthHelper _authHelper;
        private readonly IRoleRepository _roleRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAccountRepository _accountRepository;

        public AccountApplication(IAccountRepository accountRepository,
            IPasswordHasher passwordHasher, IAuthHelper authHelper, IRoleRepository roleRepository)
        {
            _authHelper = authHelper;
            _roleRepository = roleRepository;
            _passwordHasher = passwordHasher;
            _accountRepository = accountRepository;
        }


        public OperationResult Create(CreateAccount command)
        {
            var operation = new OperationResult();
            if (_accountRepository
                .Exists(x => x.Username == command.Username || x.Mobile == command.Mobile))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var password = _passwordHasher.Hash(command.Password);
            var account = new Account(command.FullName, command.Username, password,
                command.Mobile, command.RoleId);

            _accountRepository.Create(account);
            _accountRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Edit(EditAccount command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.Get(command.Id);

            if (account == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (_accountRepository
                .Exists(x => (x.Username == command.Username || x.Mobile == command.Mobile) && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            account.Edit(command.FullName, command.Username, command.Mobile, command.RoleId);
            _accountRepository.SaveChanges();
            
            return operation.Succeed();
        }

        public OperationResult ChangePassword(ChangePassword command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.Get(command.Id);

            if (account == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);
            if (command.Password != command.RePassword)
                return operation.Failed(ApplicationMessages.PasswordsNotMatch);

            var password = _passwordHasher.Hash(command.Password);
            account.ChangePassword(password);
            _accountRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Login(Login command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.GetByUsername(command.Username);
            if (account == null)
                return operation.Failed(ApplicationMessages.UserOrPassWrong);

            var result = _passwordHasher.Check(account.Password, command.Password);

            if (!result.Verified)
                return operation.Failed(ApplicationMessages.UserOrPassWrong);

            var permissions = _roleRepository.Get(account.RoleId).Permissions.Select(x => x.Code).ToList();

            var authViewModel = new AuthViewModel(account.Id, account.RoleId, account.FullName,
                account.Username, permissions, account.Mobile);

            _authHelper.Signin(authViewModel);

            return operation.Succeed();
        }

        public EditAccount GetDetails(long id)
        {
            return _accountRepository.GetDetails(id);
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            return _accountRepository.Search(searchModel);
        }

        public List<AccountViewModel> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Logout()
        {
            _authHelper.SignOut();
        }
    }
}
