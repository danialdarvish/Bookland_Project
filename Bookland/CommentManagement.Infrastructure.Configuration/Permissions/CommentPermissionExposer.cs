using System.Collections.Generic;
using _01_Framework.Infrastructure;

namespace CommentManagement.Infrastructure.Configuration.Permissions
{
    public class CommentPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Comments", new List<PermissionDto>
                    {
                        new PermissionDto(CommentPermissions.ListComments, "لیست کامنت ها"),
                        new PermissionDto(CommentPermissions.SearchComments, "جستجو در کامنت ها"),
                        new PermissionDto(CommentPermissions.ConfirmComments, "تایید کامنت ها"),
                        new PermissionDto(CommentPermissions.CancelComments, "کنسل کامنت ها"),
                    }
                }
            };
        }
    }
}
