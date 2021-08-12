using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Domain.BookAgg;
using ShopManagement.Domain.BookCategoryAgg;

namespace ShopManagement.Domain.CategoryAgg
{
    public class Category : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string Slug { get; private set; }

        public long ParentId { get; private set; }
        public Category Parent { get; private set; }
        public List<Category> Children { get; private set; }

        public List<BookCategory> BookCategories { get; private set; }

        public Category(string name, string description, string keywords, string metaDescription,
            string slug, long parentId)
        {
            Name = name;
            Description = description;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            ParentId = parentId;
        }

        public void Edit(string name, string description, string keywords, string metaDescription,
            string slug, long parentId)
        {
            Name = name;
            Description = description;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
            ParentId = parentId;
        }
    }
}
