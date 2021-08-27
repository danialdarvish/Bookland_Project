using System.Collections.Generic;
using _01_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Books", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListBooks, "نمایش کتاب ها"),
                        new PermissionDto(ShopPermissions.SearchBooks, "جستجو کتاب ها"),
                        new PermissionDto(ShopPermissions.CreateBooks, "اضافه کردن کتاب"),
                        new PermissionDto(ShopPermissions.EditBooks, "ویرایش کتاب"),
                    }
                },
                {
                    "Book Categories", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListBookCategories, "نمایش دسته بندی ها"),
                        new PermissionDto(ShopPermissions.SearchBookCategories, "جستجو در دسته بندی ها"),
                        new PermissionDto(ShopPermissions.CreateBookCategories, "ایجاد دسته بندی جدید"),
                        new PermissionDto(ShopPermissions.EditBookCategories, "ویرایش دسته بندی"),
                    }
                }
            };
        }
    }
}
