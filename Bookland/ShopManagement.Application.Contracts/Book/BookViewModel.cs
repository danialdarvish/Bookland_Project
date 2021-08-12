using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.Book
{
    public class BookViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<string> Categories { get; set; }
        public string AuthorName { get; set; }
        public string Format { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; }
        public string Picture { get; set; }
        public long CategoryId { get; set; }
        public string CreationDate { get; set; }
    }
}