namespace _01_BooklandQuery.Contract.Banner
{
    public class BannerQueryModel
    {
        public long Id { get; set; }
        public string BookName { get; set; }
        public string BookSlug { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSlug { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Price { get; set; }
        public double DoublePrice { get; set; }
        public string PriceWithDiscount { get; set; }
        public bool HasDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string Tag { get; set; }
        public long BookId { get; set; }
        public bool IsInStock { get; set; }

    }
}
