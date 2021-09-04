using System;
using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Book;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class CartModel : PageModel
    {
        public const string CookieName = "cart_items";
        public List<CartItem> CartItems;

        private readonly IBookQuery _bookQuery;

        public CartModel(IBookQuery bookQuery)
        {
            _bookQuery = bookQuery;
            CartItems = new List<CartItem>();
        }

        public List<CartItem> LoadCookie()
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

            return cartItems;
        }

        public void ClearCookie()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            cartItems.Clear();
            Response.Cookies.Append(CookieName, serializer.Serialize(cartItems));
        }

        public void OnGet()
        {
            var cartItems = LoadCookie();
            CartItems = _bookQuery.CheckInventoryStatus(cartItems);
        }

        public IActionResult OnGetRemoveFromCart(long id)
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            Response.Cookies.Delete(CookieName);
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
            var itemToRemove = cartItems.FirstOrDefault(x => x.Id == id);
            cartItems.Remove(itemToRemove);

            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(2)
            };
            Response.Cookies.Append(CookieName, serializer.Serialize(cartItems), options);

            return RedirectToPage("/Cart");
        }

        public IActionResult OnGetGoToCheckout()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);

            foreach (var item in cartItems)
            {
                item.TotalItemPrice = item.UnitPrice * item.Count;
            }

            CartItems = _bookQuery.CheckInventoryStatus(cartItems);

            return RedirectToPage(CartItems.Any(x => !x.IsInStock) ? "/Cart" : "/Checkout");
        }
    }
}
