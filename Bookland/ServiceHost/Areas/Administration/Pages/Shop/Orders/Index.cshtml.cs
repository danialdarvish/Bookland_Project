using System.Collections.Generic;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Areas.Administration.Pages.Shop.Orders
{
    public class IndexModel : PageModel
    {
        public SelectList Accounts;
        public List<OrderViewModel> Orders;
        public OrderSearchModel SearchModel;
        private readonly IOrderApplication _orderApplication;
        private readonly IAccountApplication _accountApplication;

        public IndexModel(IOrderApplication orderApplication, IAccountApplication accountApplication)
        {
            _orderApplication = orderApplication;
            _accountApplication = accountApplication;
        }


        public void OnGet(OrderSearchModel searchModel)
        {
            Orders = _orderApplication.Search(searchModel);
            Accounts = new SelectList(_accountApplication.GetAccounts(), "Id", "FullName");
        }

        public IActionResult OnGetConfirm(long id)
        {
            _orderApplication.PaymentSucceeded(id, 0);
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetCancel(long id)
        {
            _orderApplication.Cancel(id);
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetItems(long id)
        {
            var items = _orderApplication.GetItemsBy(id);
            return Partial("Items", items);
        }
    }
}
