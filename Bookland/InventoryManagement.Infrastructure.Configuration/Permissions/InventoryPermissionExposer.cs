using System.Collections.Generic;
using _01_Framework.Infrastructure;

namespace InventoryManagement.Infrastructure.Configuration.Permissions
{
    public class InventoryPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Inventory", new List<PermissionDto>
                    {
                        new PermissionDto(InventoryPermissions.ListInventory, "نمایش انبار ها"),
                        new PermissionDto(InventoryPermissions.SearchInventory, "جستجو در انبار ها"),
                        new PermissionDto(InventoryPermissions.CreateInventory, "ایجاد انبار جدید"),
                        new PermissionDto(InventoryPermissions.EditInventory, "ویرایش انبار"),
                        new PermissionDto(InventoryPermissions.Increase, "افزایش موجودی"),
                        new PermissionDto(InventoryPermissions.Reduce, "کاهش موجودی"),
                        new PermissionDto(InventoryPermissions.OperationLog, "مشاهده گردش انبار"),
                    }
                }
            };
        }
    }
}
