using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BestSellingViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
