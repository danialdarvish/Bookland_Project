namespace ShopManagement.Application.Contracts.Order
{
    public class OrderSearchModel
    {
        public long AccountId { get; set; }
        public string Address { get; set; }
        public bool IsCanceled { get; set; }
    }
}
