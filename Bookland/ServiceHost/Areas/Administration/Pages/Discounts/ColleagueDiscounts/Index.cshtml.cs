using System.Collections.Generic;
using _01_Framework.Infrastructure;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using DiscountManagement.Configuration.Permissions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Book;

namespace ServiceHost.Areas.Administration.Pages.Discounts.ColleagueDiscounts
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public ColleagueDiscountSearchModel SearchModel;
        public List<ColleagueDiscountViewModel> ColleagueDiscounts;
        public SelectList Books;

        private readonly IBookApplication _bookApplication;
        private readonly IColleagueDiscountApplication _colleagueDiscountApplication;

        public IndexModel(IBookApplication bookApplication, IColleagueDiscountApplication colleagueDiscountApplication)
        {
            _bookApplication = bookApplication;
            _colleagueDiscountApplication = colleagueDiscountApplication;
        }


        [NeedsPermission(DiscountPermissions.ListColleagueDiscounts)]
        public void OnGet(ColleagueDiscountSearchModel searchModel)
        {
            ColleagueDiscounts = _colleagueDiscountApplication.Search(searchModel);
            Books = new SelectList(_bookApplication.GetBooks(), "Id", "Name");
        }

        [NeedsPermission(DiscountPermissions.DefineColleagueDiscounts)]
        public IActionResult OnGetCreate()
        {
            var command = new DefineColleagueDiscount
            {
                Books = _bookApplication.GetBooks()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(DefineColleagueDiscount command)
        {
            var result = _colleagueDiscountApplication.Define(command);
            return new JsonResult(result);
        }

        [NeedsPermission(DiscountPermissions.EditColleagueDiscounts)]
        public IActionResult OnGetEdit(long id)
        {
            var customerDiscount = _colleagueDiscountApplication.GetDetails(id);
            customerDiscount.Books = _bookApplication.GetBooks();
            return Partial("Edit", customerDiscount);
        }

        public JsonResult OnPostEdit(EditColleagueDiscount command)
        {
            var result = _colleagueDiscountApplication.Edit(command);
            return new JsonResult(result);
        }

        [NeedsPermission(DiscountPermissions.RemoveColleagueDiscounts)]
        public IActionResult OnGetRemove(long id)
        {
            _colleagueDiscountApplication.Remove(id);
            return RedirectToPage("./Index");
        }

        [NeedsPermission(DiscountPermissions.RestoreColleagueDiscounts)]
        public IActionResult OnGetRestore(long id)
        {
            _colleagueDiscountApplication.Restore(id);
            return RedirectToPage("./Index");
        }
    }
}
