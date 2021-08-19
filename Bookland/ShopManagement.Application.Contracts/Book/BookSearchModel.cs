namespace ShopManagement.Application.Contracts.Book
{
    public class BookSearchModel
    {
        public string Name { get; set; }
        public string Format { get; set; }
        public string PublishDate { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public long CategoryId { get; set; }
        public bool IsEditorsChoice { get; set; }
    }
}