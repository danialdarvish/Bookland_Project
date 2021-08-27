using System.Collections.Generic;
using _01_Framework.Infrastructure;
using AccountManagement.Configuration.Permissions;

namespace BlogManagement.Configuration.Permissions
{
    public class AccountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Accounts", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.ListAccounts, "لیست کاربران"),
                        new PermissionDto(AccountPermissions.SearchAccounts, "جستجو در کاربران"),
                        new PermissionDto(AccountPermissions.CreateAccounts, "ایجاد کاربر"),
                        new PermissionDto(AccountPermissions.EditAccounts, "ویرایش کاربران"),
                        new PermissionDto(AccountPermissions.ChangeAccountsPasswords, "ویرایش پسورد کاربران")
                    }
                },
                {

                    "Roles", new List<PermissionDto>
                    {
                        new PermissionDto(AccountPermissions.EditRoles, "لیست نقش ها"),
                        new PermissionDto(AccountPermissions.CreateRoles, "ایجاد نقش جدید"),
                        new PermissionDto(AccountPermissions.EditRoles, "ویرایش نقش")
                    }
                }

            };
        }
    }
}
