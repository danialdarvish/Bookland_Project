using System.Collections.Generic;
using _01_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Role;
using AccountManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ServiceHost.Areas.Administration.Pages.Accounts.Account
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public AccountSearchModel SearchModel;
        public List<AccountViewModel> Accounts;
        public SelectList Roles;

        private readonly IAccountApplication _accountApplication;
        private readonly IRoleApplication _roleApplication;

        public IndexModel(IAccountApplication accountApplication,
            IRoleApplication roleApplication)
        {
            _accountApplication = accountApplication;
            _roleApplication = roleApplication;
        }


        [NeedsPermission(AccountPermissions.ListAccounts)]
        public void OnGet(AccountSearchModel searchModel)
        {
            Roles = new SelectList(_roleApplication.List(), "Id", "Name");
            Accounts = _accountApplication.Search(searchModel);
        }

        [NeedsPermission(AccountPermissions.CreateAccounts)]
        public IActionResult OnGetCreate()
        {
            var command = new CreateAccount
            {
                Roles = _roleApplication.List()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateAccount command)
        {
            var result = _accountApplication.Create(command);
            return new JsonResult(result);
        }

        [NeedsPermission(AccountPermissions.EditAccounts)]
        public IActionResult OnGetEdit(long id)
        {
            var account = _accountApplication.GetDetails(id);
            account.Roles = _roleApplication.List();
            return Partial("Edit", account);
        }

        public JsonResult OnPostEdit(EditAccount command)
        {
            var result = _accountApplication.Edit(command);
            return new JsonResult(result);
        }

        [NeedsPermission(AccountPermissions.ChangeAccountsPasswords)]
        public IActionResult OnGetChangePassword(long id)
        {
            var command = new ChangePassword
            {
                Id = id
            };
            return Partial("ChangePassword", command);
        }

        public IActionResult OnPostChangePassword(ChangePassword command)
        {
            var result = _accountApplication.ChangePassword(command);
            return new JsonResult(result);
        }
    }
}
