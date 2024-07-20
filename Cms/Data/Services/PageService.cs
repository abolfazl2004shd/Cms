using Cms.Data.Context;
using Cms.Data.Repositories;
using Cms.Models;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Services
{
    public class PageService(CmsDbContext db) : IPage
    {
        private readonly CmsDbContext _context = db;

        public List<Page> AllPages()
        {
            return [.. _context.Pages];
        }

        public bool DeletePafe(int id)
        {
            var page = GetPageById(id);
            try
            {
                _context.Entry(page).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }

        }

        public bool DeletePage(Page page)
        {
            try
            {
                _context.Entry(page).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }

        }

        public bool DeletePage(int id)
        {
            throw new NotImplementedException();
        }

        public Page GetPageById(int id)
        {
            var page = _context.Pages.Find(id);
            return page;
        }

        public bool InsertPage(Page page)
        {
            try
            {
                _context.Entry(page).State = EntityState.Added;
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
            var page = GetPageById(id);
            try
            {
                _context.Entry(page).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePage(int id)
        {
            throw new NotImplementedException();
        }
    }
}
