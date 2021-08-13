using _01_Framework.Domain;

namespace DiscountManagement.Domain.ColleagueDiscountAgg
{
    public class ColleagueDiscount : EntityBase
    {
        public long BookId { get; private set; }
        public int DiscountRate { get; private set; }
        public bool IsRemoved { get; private set; }

        public ColleagueDiscount(long bookId, int discountRate)
        {
            BookId = bookId;
            DiscountRate = discountRate;
            IsRemoved = false;
        }

        public void Edit(long bookId, int discountRate)
        {
            BookId = bookId;
            DiscountRate = discountRate;
        }

        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
