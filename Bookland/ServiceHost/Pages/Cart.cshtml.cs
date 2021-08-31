using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class CartModel : PageModel
    {
        public const string CookieName = "cart_items";
        public List<CartItem> CartItems;

        public CartModel()
        {
            CartItems = new List<CartItem>();
        }

        public void OnGet()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            CartItems = serializer.Deserialize<List<CartItem>>(value);

            foreach (var item in CartItems)
            {
                item.TotalItemPrice = item.UnitPrice * item.Count;
            }
        }
    }
}
