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
                    "Book", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListBooks, "ListBooks"),
                        new PermissionDto(ShopPermissions.SearchBooks, "SearchBooks"),
                        new PermissionDto(ShopPermissions.CreateBooks, "CreateBook"),
                        new PermissionDto(ShopPermissions.EditBooks, "EditBook"),
                    }
                },
                {
                    "BookCategory", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListBookCategories, "ListBookCategories"),
                        new PermissionDto(ShopPermissions.SearchBookCategories, "SearchBookCategories"),
                        new PermissionDto(ShopPermissions.CreateBookCategories, "CreateBookCategory"),
                        new PermissionDto(ShopPermissions.EditBookCategories, "EditBookCategory"),
                    }
                },

            };
        }
    }
}
