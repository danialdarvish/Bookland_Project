using System.Collections.Generic;

namespace _01_BooklandQuery.Contract.Article
{
    public interface IArticleQuery
    {
        ArticleQueryModel GetArticleDetails(string slug);
        List<ArticleQueryModel> GetRelatedArticles(long categoryId);
        List<ArticleQueryModel> LatestArticles();
    }
}
