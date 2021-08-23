using _01_BooklandQuery.Contract.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        private readonly IArticleQuery _articleQuery;

        public LatestArticlesViewComponent(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }


        public IViewComponentResult Invoke(string type)
        {
            var latestArticles = _articleQuery.LatestArticles();
            return View(type, latestArticles);
        }
    }
}
