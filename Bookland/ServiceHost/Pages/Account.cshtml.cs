using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class AccountModel : PageModel
    {
        [TempData]
        public string LoginMessage { get; set ; }

        [TempData]
        public string RegisterMessage { get; set; }

        public bool IsSuccessful { get; set; }


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

        public IActionResult OnPostRegister(CreateAccount command)
        {
            if (ModelState.IsValid)
            {
                var result = _accountApplication.Create(command);
                if (result.IsSucceed)
                {
                    RedirectToPage("/Account");
                    IsSuccessful = true;
                }
                RegisterMessage = result.Message;
                return RedirectToPage("/Account");
            }

            RegisterMessage = "همه فیلد ها را پر کنید";
            IsSuccessful = false;
            return RedirectToPage("/Account");
        }
    }
}
