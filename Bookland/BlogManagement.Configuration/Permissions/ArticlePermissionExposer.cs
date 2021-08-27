using System.Collections.Generic;
using _01_Framework.Infrastructure;
using CommentManagement.Infrastructure.Configuration.Permissions;

namespace BlogManagement.Configuration.Permissions
{
    public class ArticlePermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Articles", new List<PermissionDto>
                    {
                        new PermissionDto(ArticlePermissions.ListArticles, "لیست مقالات"),
                        new PermissionDto(ArticlePermissions.SearchArticles, "جستجو در مقالات"),
                        new PermissionDto(ArticlePermissions.CreateArticles, "ایجاد مقاله"),
                        new PermissionDto(ArticlePermissions.EditArticles, "ویرایش مقاله"),
                    }
                },
                {

                    "Article Categories", new List<PermissionDto>
                    {
                        new PermissionDto(ArticlePermissions.ListArticleCategories, "لیست دسته بندی مقالات"),
                        new PermissionDto(ArticlePermissions.SearchArticleCategories, "جستجو در دسته بندی مقالات"),
                        new PermissionDto(ArticlePermissions.CreateArticleCategories, "ایجاد دسته بندی مقاله"),
                        new PermissionDto(ArticlePermissions.EditArticleCategories, "ویرایش دسته بندی مقاله"),
                    }
                }

            };
        }
    }
}
