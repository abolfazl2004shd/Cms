using Cms.Data.Context;
using Cms.Data.Repositories;
using Cms.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Services
{
    public class PageCommentService(CmsDbContext db) : IPageComment
    {
        private readonly CmsDbContext _context = db;

        public List<PageComment> AllComments()
        {
            return [.. _context.PageComments];
        }

        public bool DeleteComment(int id)
        {
            try
            {
                var comment = GetPageCommentById(id);
                _context.Entry(comment).State = EntityState.Deleted;
                Save();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool DeleteComment(PageComment comment)
        {
            throw new NotImplementedException();
        }

        public PageComment GetPageCommentById(int id)
        {
            var comment = _context.PageComments.Find(id);
            return comment;
        }

        public bool InsertComment(PageComment comment)
        {
            throw new NotImplementedException();
        }

        public List<PageComment> PageComments(int id)
        {
            var comments = _context.PageComments.Where(p => p.PageId == id);
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
    }
}
