using Cms.Models;

namespace Cms.Data.Services
{
    public interface IArticleService
    {
        Article GetArticleById(int id);
        List<Article> RelatedArticles(int id);
        List<Article> AllArticles();
        bool InsertArticle(Article Article);
        bool UpdateArticle(int id);
        bool DeleteArticle(int id);
        bool DeleteArticle(Article Article);
        List<Keyword> AllKeywords(int ArticleId);
        List<Article> Filter(string query);
        bool Save();
    }
}
