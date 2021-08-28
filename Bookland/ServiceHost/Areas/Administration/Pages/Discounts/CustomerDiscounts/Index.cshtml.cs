using System.Collections.Generic;
using _01_Framework.Infrastructure;
using DiscountManagement.Application.Contract.CustomerDiscount;
using DiscountManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Book;

namespace ServiceHost.Areas.Administration.Pages.Discounts.CustomerDiscounts
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public CustomerDiscountSearchModel SearchModel;
        public List<CustomerDiscountViewModel> CustomerDiscounts;
        public SelectList Books;

        private readonly IBookApplication _bookApplication;
        private readonly ICustomerDiscountApplication _customerDiscountApplication;

        public IndexModel(IBookApplication bookApplication, ICustomerDiscountApplication customerDiscountApplication)
        {
            _bookApplication = bookApplication;
            _customerDiscountApplication = customerDiscountApplication;
        }


        [NeedsPermission(DiscountPermissions.ListDiscounts)]
        public void OnGet(CustomerDiscountSearchModel searchModel)
        {
            CustomerDiscounts = _customerDiscountApplication.Search(searchModel);
            Books = new SelectList(_bookApplication.GetBooks(), "Id", "Name");
        }

        [NeedsPermission(DiscountPermissions.DefineDiscounts)]
        public IActionResult OnGetCreate()
        {
            var command = new DefineCustomerDiscount
            {
                Books = _bookApplication.GetBooks()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(DefineCustomerDiscount command)
        {
            var result = _customerDiscountApplication.Define(command);
            return new JsonResult(result);
        }

        [NeedsPermission(DiscountPermissions.EditDiscounts)]
        public IActionResult OnGetEdit(long id)
        {
            var customerDiscount = _customerDiscountApplication.GetDetails(id);
            customerDiscount.Books = _bookApplication.GetBooks();
            return Partial("Edit", customerDiscount);
        }

        public JsonResult OnPostEdit(EditCustomerDiscount command)
        {
            var result = _customerDiscountApplication.Edit(command);
            return new JsonResult(result);
        }
    }
}
