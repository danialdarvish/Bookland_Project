using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        public const string CookieName = "cart_items";

        public IViewComponentResult Invoke()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            if (cartItems == null)
                cartItems = new List<CartItem>();
            foreach (var item in cartItems)
            {
                item.CalculateTotalItemPrice();
            }

            var totalAmount = cartItems.Sum(x => x.TotalItemPrice);
            var cartModel = new CartModel(totalAmount, cartItems);
            return View(cartModel);
        }
    }
}
