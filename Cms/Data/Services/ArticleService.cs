using Cms.Data.Context;
using Cms.Models;

namespace Cms.Data.Services
{
    public class ArticleService : IArticleService
    {
        private readonly CmsDbContext _context;

        public ArticleService(CmsDbContext db)
        {
            _context = db;
        }

        public List<Keyword> AllKeywords(int articleId)
        {
            return _context.Keywords.Where(k => k.ArticleId == articleId).ToList();
        }

        public List<Article> AllArticles()
        {
            return _context.Articles.ToList();
        }

        public bool DeleteArticle(int id)
        {
            var article = GetArticleById(id);
            if (article == null)
                return false;

            try
            {
                _context.Articles.Remove(article);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteArticle(Article article)
        {
            if (article == null)
                return false;

            try
            {
                _context.Articles.Remove(article);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Article GetArticleById(int id)
        {
            return _context.Articles.Find(id);
        }

        public bool InsertArticle(Article article)
        {
            if (article == null)
                return false;

            try
            {
                _context.Articles.Add(article);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateArticle(int id)
        {
            Article article = GetArticleById(id);
            if (article == null)
                return false;

            try
            {
                _context.Articles.Update(article);
                Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

      
    }
}
