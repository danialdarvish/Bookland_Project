using _01_BooklandQuery.Contract;
using _01_BooklandQuery.Contract.Book;
using _01_Framework.Application;
using _01_Framework.Application.ZarinPal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ServiceHost.Pages
{
    [Authorize]
    public class CheckoutModel : PageModel
    {
        public Cart Cart;
        public const string CookieName = "cart_items";

        private readonly IBookQuery _bookQuery;
        private readonly IAuthHelper _authHelper;
        private readonly ICartService _cartService;
        private readonly IZarinPalFactory _zarinPalFactory;
        private readonly IOrderApplication _orderApplication;
        private readonly ICartCalculatorService _cartCalculatorService;

        public CheckoutModel(ICartCalculatorService cartCalculatorService, ICartService cartService, IBookQuery bookQuery, IOrderApplication orderApplication, IZarinPalFactory zarinPalFactory, IAuthHelper authHelper)
        {
            Cart = new Cart();
            _bookQuery = bookQuery;
            _authHelper = authHelper;
            _cartService = cartService;
            _zarinPalFactory = zarinPalFactory;
            _orderApplication = orderApplication;
            _cartCalculatorService = cartCalculatorService;
        }

        public List<CartItem> LoadCookie()
        {
            var serializer = new JavaScriptSerializer();
            var value = Request.Cookies[CookieName];
            var cartItems = serializer.Deserialize<List<CartItem>>(value);
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
            Cart = _cartCalculatorService.ComputeCart(cartItems);
            _cartService.Set(Cart);
        }

        public IActionResult OnPostPay(int paymentMethod)
        {
            var cart = _cartService.Get();
            cart.SetPaymentMethod(paymentMethod);
            var result = _bookQuery.CheckInventoryStatus(cart.Items);
            if (result.Any(x => !x.IsInStock))
                return RedirectToPage("/Cart");

            var orderId = _orderApplication.PlaceOrder(cart);

            if (paymentMethod == 1)
            {
                var accountUserName = _authHelper.CurrentAccountInfo().Username;

                var paymentResponse = _zarinPalFactory
                    .CreatePaymentRequest(cart.PayAmount.ToString(CultureInfo.InvariantCulture), "",
                        "", "خرید کتاب", orderId);

                return Redirect($"https://{_zarinPalFactory.Prefix}.zarinpal.com/pg/StartPay/{paymentResponse.Authority}");
            }
            else
            {
                var paymentResult = new PaymentResult();
                paymentResult.Succeeded(".سفارش شما با موفقیت ثبت شد", "");
                //Response.Cookies.Delete(CookieName);
                ClearCookie();
                return RedirectToPage("/PaymentResult", paymentResult);
            }
        }

        public IActionResult OnGetCallBack([FromQuery] string authority, [FromQuery] string status,
            [FromQuery] long oId)
        {
            var orderAmount = _orderApplication.GetAmountBy(oId);
            var verificationResponse = _zarinPalFactory
                .CreateVerificationRequest(authority, orderAmount.ToString(CultureInfo.InvariantCulture));

            var result = new PaymentResult();
            if (status == "OK" && verificationResponse.Status == 100)
            {
                var issueTrackingNo = _orderApplication.PaymentSucceeded(oId, verificationResponse.RefID);
                Response.Cookies.Delete(CookieName);
                result = result.Succeeded("انجام شد", issueTrackingNo);

                return RedirectToPage("/PaymentResult", result);
            }

            result = result.Failed("نا موفق");
            return RedirectToPage("/PaymentResult", result);
        }
    }
}
