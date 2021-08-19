using _01_BooklandQuery.Contract.Banner;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class BannerViewComponent : ViewComponent
    {
        private readonly IBannerQuery _bannerQuery;

        public BannerViewComponent(IBannerQuery bannerQuery)
        {
            _bannerQuery = bannerQuery;
        }

        public IViewComponentResult Invoke()
        {
            var banner = _bannerQuery.GetBanner();
            return View(banner);
        }
    }
}
