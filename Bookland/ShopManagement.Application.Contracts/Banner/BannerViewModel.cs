namespace ShopManagement.Application.Contracts.Banner
{
    public class BannerViewModel
    {
        public long Id { get; set; }
        public string BookName { get; set; }
        public string Picture { get; set; }
        public string Tag { get; set; }
        public string CreationDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}