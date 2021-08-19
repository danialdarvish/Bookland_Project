using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopManagement.Application.Contracts.Banner;
using ShopManagement.Application.Contracts.Book;
using ShopManagement.Application.Contracts.Quote;

namespace ServiceHost.Areas.Administration.Pages.Shop.Banners
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        public BannerSearchModel SearchModel;
        public List<BannerViewModel> Banners;
        public SelectList Books;

        private readonly IBookApplication _bookApplication;
        private readonly IBannerApplication _bannerApplication;
        public IndexModel(IBannerApplication bannerApplication, IBookApplication bookApplication)
        {
            _bookApplication = bookApplication;
            _bannerApplication = bannerApplication;
        }


        public void OnGet(BannerSearchModel searchModel)
        {
            Banners = _bannerApplication.Search(searchModel);
            Books = new SelectList(_bookApplication.GetBooks(), "Id", "Name");
        }

        public IActionResult OnGetCreate()
        {
            var command = new CreateBanner
            {
                Books = _bookApplication.GetBooks()
            };
            return Partial("./Create", command);
        }

        public JsonResult OnPostCreate(CreateBanner command)
        {
            var result = _bannerApplication.Create(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetEdit(long id)
        {
            var banner = _bannerApplication.GetDetails(id);
            banner.Books = _bookApplication.GetBooks();
            return Partial("Edit", banner);
        }

        public JsonResult OnPostEdit(EditBanner command)
        {
            var result = _bannerApplication.Edit(command);
            return new JsonResult(result);
        }

        public IActionResult OnGetRemove(long id)
        {
            var result = _bannerApplication.Remove(id);
            Message = result.Message;
            if (result.IsSucceed)
                return RedirectToPage("./Index");
            
            return RedirectToPage("./Index");

        }

        public IActionResult OnGetRestore(long id)
        {
            var result = _bannerApplication.Restore(id);
            Message = result.Message;
            if (result.IsSucceed)
                return RedirectToPage("./Index");

            return RedirectToPage("./Index");
        }
    }
}
