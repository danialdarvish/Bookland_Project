using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class NewReleaseViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
