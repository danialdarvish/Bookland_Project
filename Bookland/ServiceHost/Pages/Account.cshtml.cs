using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AccountModel : PageModel
    {
        [TempData]
        public string LoginMessage { get; set ; }

        private readonly IAccountApplication _accountApplication;

        public AccountModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostLogin(Login command)
        {
            var result = _accountApplication.Login(command);
            if (result.IsSucceed)
                return RedirectToPage("/Index");

            LoginMessage = result.Message;
            return RedirectToPage("/Account");
        }

        public IActionResult OnGetLogout()
        {
            _accountApplication.Logout();
            return RedirectToPage("/Index");
        }
    }
}
