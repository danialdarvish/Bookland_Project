using System.Linq;
using _01_BooklandQuery.Contract.Inventory;
using InventoryManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class InventoryQuery : IInventoryQuery
    {
        private readonly ShopContext _shopContext;
        private readonly InventoryContext _inventoryContext;

        public InventoryQuery(ShopContext shopContext, InventoryContext inventoryContext)
        {
            _shopContext = shopContext;
            _inventoryContext = inventoryContext;
        }


        public StockStatus CheckStock(IsInStock command)
        {
            var inventory = _inventoryContext.Inventory
                .FirstOrDefault(x => x.BookId == command.BookId);
            if (inventory == null || inventory.CalculateCurrentCount() < command.Count)
            {
                var book = _shopContext.Books
                    .Select(x => new { x.Id, x.Name })
                    .FirstOrDefault(x => x.Id == command.BookId);

                return new StockStatus()
                {
                    IsInStock = false,
                    BookName = book?.Name
                };
            }

            return new StockStatus
            {
                IsInStock = true
            };
        }
    }
}
