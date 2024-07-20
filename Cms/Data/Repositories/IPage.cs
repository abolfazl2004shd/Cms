using Cms.Models;

namespace Cms.Data.Repositories
{
    public interface IPage
    {
        Page GetPageById(int id);
        List<Page> AllPages();
        bool InsertPage(Page page);
        bool UpdatePage(int id);
        bool DeletePage(int id);
        bool DeletePage(Page page);
        bool Save();
    }
}
