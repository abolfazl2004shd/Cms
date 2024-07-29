using Cms.Data.Context;
using Cms.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Services
{
    public class ArticleCommentService(CmsDbContext db) : IArticleCommentService
    {
        private readonly CmsDbContext _context = db;

        public List<ArticleComment> AllComments()
        {
            return [.. _context.ArticleComments];
        }

        public bool DeleteComment(int id)
        {
            try
            {
                var comment = GetArticleCommentById(id);
                _context.Entry(comment).State = EntityState.Deleted;
                Save();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteComment(ArticleComment comment)
        {
            throw new NotImplementedException();
        }

        public ArticleComment GetArticleCommentById(int id)
        {
            var comment = _context.ArticleComments.Find(id);
            return comment;
        }

        public bool InsertComment(ArticleComment comment)
        {
            throw new NotImplementedException();
        }

        public List<ArticleComment> ArticleComments(int id)
        {
            var comments = _context.ArticleComments.Where(p => p.ArticleId == id);
            return [.. comments];
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

        public int NumberOfComments(int ArticleId)
        {
            var comments = ArticleComments(ArticleId);
            return comments.Count;
        }
    }
}
