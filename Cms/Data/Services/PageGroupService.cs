using Cms.Data.Context;
using Cms.Data.Repositories;
using Cms.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Services
{
    public class PageGroupService(CmsDbContext db) : IPageGroup
    {
        private readonly CmsDbContext _context = db;
        public List<PageGroup> AllGroups()
        {
            return [.. _context.PageGroups];
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

        public bool DeleteGroup(PageGroup group)
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

        public PageGroup GetGroupById(int id)
        {
            var group = _context.PageGroups.Find(id);
            return group;
        }

        public bool InsertGroup(PageGroup group)
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
