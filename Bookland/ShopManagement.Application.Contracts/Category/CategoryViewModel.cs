namespace ShopManagement.Application.Contracts.Category
{
    public class CategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ParentCategory { get; set; }
        public long ChildrenCount { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
    }
}