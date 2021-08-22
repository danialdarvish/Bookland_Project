using _01_BooklandQuery.Contract.Article;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.ViewComponents
{
    public class RelatedArticlesViewComponent : ViewComponent
    {
        private readonly IArticleQuery _articleQuery;

        public RelatedArticlesViewComponent(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }

        public IViewComponentResult Invoke(long categoryId)
        {
            var relatedArticles = _articleQuery.GetRelatedArticles(categoryId);
            return View(relatedArticles);
        }
    }
}
