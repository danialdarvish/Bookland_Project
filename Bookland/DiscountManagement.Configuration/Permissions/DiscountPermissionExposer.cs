using System.Collections.Generic;
using _01_Framework.Infrastructure;

namespace DiscountManagement.Configuration.Permissions
{
    public class DiscountPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Discounts", new List<PermissionDto>
                    {
                        new PermissionDto(DiscountPermissions.ListDiscounts, "نمایش تخفیف ها"),
                        new PermissionDto(DiscountPermissions.SearchDiscounts, "جستجو تخفیف ها"),
                        new PermissionDto(DiscountPermissions.DefineDiscounts, "ایجاد تخفیف جدید"),
                        new PermissionDto(DiscountPermissions.EditDiscounts, "ویرایش تخفیف ها"),
                    }
                },
                {
                    "Colleague Discounts", new List<PermissionDto>
                    {
                        new PermissionDto(DiscountPermissions.ListColleagueDiscounts, "نمایش تخفیف های همکاری"),
                        new PermissionDto(DiscountPermissions.SearchColleagueDiscounts, "جستجو در تخفیف های همکاری"),
                        new PermissionDto(DiscountPermissions.DefineColleagueDiscounts, "ایجاد تخفیف همکاری جدید"),
                        new PermissionDto(DiscountPermissions.EditColleagueDiscounts, "ویرایش تخفیف همکاری"),
                        new PermissionDto(DiscountPermissions.RemoveColleagueDiscounts, "غیرفعال تخفیف همکاری"),
                        new PermissionDto(DiscountPermissions.RestoreColleagueDiscounts, "فعال کردن تخفیف همکاری")
                    }
                }
            };
        }
    }
}
