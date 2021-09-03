using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;

namespace _01_BooklandQuery
{
    public class CartModel
    {
        public double TotalAmount { get; set; }
        public List<CartItem> Items { get; set; }

        public CartModel(double totalAmount, List<CartItem> items)
        {
            TotalAmount = totalAmount;
            Items = items;
        }
    }
}
