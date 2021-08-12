namespace ShopManagement.Application.Contracts.Author
{
    public class CreateAuthor
    {
        public string FullName { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public string MetaDescription { get; set; }
    }
}
