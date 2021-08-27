using System.Collections.Generic;

namespace _01_Framework.Application
{
    public interface IAuthHelper
    {
        bool IsAuthenticated();
        void SignOut();
        void Signin(AuthViewModel account);
        string CurrentAccountRole();
        AuthViewModel CurrentAccountInfo();
        List<int> GetPermissions();
        long CurrentAccountId();
        string CurrentAccountMobile();
    }
}
