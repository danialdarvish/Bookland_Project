using System.Collections.Generic;
using _01_BooklandQuery.Contract.Comment;

namespace _01_BooklandQuery.Contract.Book
{
    public class BookQueryModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public double DoublePrice { get; set; }
        public string PriceWithDiscount { get; set; }
        public int DiscountRate { get; set; }
        public string DiscountPrice { get; set; }
        public List<long> CategoryId { get; set; }
        public List<string> CategoryNames { get; set; }
        public int PageCount { get; set; }
        public string Format { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public string PublishDate { get; set; }
        public string Isbn { get; set; }
        public string CategorySlug { get; set; }
        public bool HasDiscount { get; set; }
        public string DiscountExpireDate { get; set; }
        public string ShortDescription { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public bool IsInStock { get; set; }
        public bool IsEditorsChoice { get; set; }

        public string AuthorName { get; set; }
        public List<CommentQueryModel> Comments { get; set; }
    }
}
