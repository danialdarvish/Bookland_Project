using _01_Framework.Domain;

namespace ShopManagement.Domain.CategoryAgg
{
    public class Category : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Keywords { get; private set; }
        public string MetaDescription { get; private set; }
        public string Slug { get; private set; }

        public Category(string name, string description, string keywords, string metaDescription,
            string slug)
        {
            Name = name;
            Description = description;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
        }

        public void Edit(string name, string description, string keywords, string metaDescription,
            string slug)
        {
            Name = name;
            Description = description;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
        }
    }
}
