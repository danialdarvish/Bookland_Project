using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using _01_Framework.Application;
using ShopManagement.Application.Contracts.Book;

namespace InventoryManagement.Application.Contracts.Inventory
{
    public class CreateInventory
    {
        [Range(1, 100000, ErrorMessage = ValidationMessages.IsRequired)]
        public long BookId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = ValidationMessages.IsRequired)]
        public double UnitPrice { get; set; }

        public List<BookViewModel> Books { get; set; }
    }
}
