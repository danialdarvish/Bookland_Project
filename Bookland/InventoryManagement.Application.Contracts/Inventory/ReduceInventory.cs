namespace InventoryManagement.Application.Contracts.Inventory
{
    public class ReduceInventory
    {
        public long InventoryId { get; set; }
        public long BookId { get; set; }
        public long Count { get; set; }
        public string Description { get; set; }
        public long OrderId { get; set; }

        public ReduceInventory()
        {
            
        }

        public ReduceInventory(long bookId, long count, string description, long orderId)
        {
            BookId = bookId;
            Count = count;
            Description = description;
            OrderId = orderId;
        }
    }
}