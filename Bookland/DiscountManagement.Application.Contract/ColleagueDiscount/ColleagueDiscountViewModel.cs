namespace DiscountManagement.Application.Contract.ColleagueDiscount
{
    public class ColleagueDiscountViewModel
    {
        public long Id { get; set; }
        public long BookId { get; set; }
        public string Book{ get; set; }
        public int DiscountRate{ get; set; }
        public string CreationDate { get; set; }
        public bool IsRemoved { get; set; }
    }
}