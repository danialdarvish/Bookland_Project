using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class CallToActionViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
