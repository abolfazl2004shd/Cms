using Cms.Data.Context;
using Cms.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Services
{
    public class ArticleGroupService(CmsDbContext db) : IArticleGroupService
    {
        private readonly CmsDbContext _context = db;
        public List<ArticleGroup> AllGroups()
        {
            return [.. _context.ArticleGroups];
        }

        public bool DeleteGroup(int id)
        {
            var group = GetGroupById(id);
            try
            {
                _context.Entry(group).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }

        }

        public bool DeleteGroup(ArticleGroup group)
        {
            try
            {
                _context.Entry(group).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }

        }

        public ArticleGroup GetGroupById(int id)
        {
            var group = _context.ArticleGroups.Find(id);
            return group;
        }

        public bool InsertGroup(ArticleGroup group)
        {
            try
            {
                _context.Entry(group).State = EntityState.Added;
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
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateGroup(int id)
        {
            var group = GetGroupById(id);
            try
            {
                _context.Entry(group).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
