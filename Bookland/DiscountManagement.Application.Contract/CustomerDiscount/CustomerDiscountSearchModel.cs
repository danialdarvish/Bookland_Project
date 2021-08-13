namespace DiscountManagement.Application.Contract.CustomerDiscount
{
    public class CustomerDiscountSearchModel
    {
        public long BookId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}