namespace ShopManagement.Application.Contracts.Quote
{
    public class QuoteViewModel
    {
        public long Id { get; set; }
        public string PersonName { get; set; }
        public string PersonPost { get; set; }
        public string Text { get; set; }
        public string PersonPicture { get; set; }
        public bool IsRemoved { get; set; }
        public string CreationDate { get; set; }
    }
}