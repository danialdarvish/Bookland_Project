using _01_Framework.Domain;
using AccountManagement.Domain.RoleAgg;

namespace AccountManagement.Domain.AccountAgg
{
    public class Account : EntityBase
    {
        public string FullName { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public long RoleId { get; private set; }
        public Role Role { get; private set; }

        public Account(string fullName, string username, string password, string mobile,
            long roleId)
        {
            FullName = fullName;
            Username = username;
            Password = password;
            Mobile = mobile;
            RoleId = roleId == 0 ? 2 : roleId;

        }

        public void Edit(string fullName, string username, string mobile, long roleId)
        {
            FullName = fullName;
            Username = username;
            Mobile = mobile;
            RoleId = roleId;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}
