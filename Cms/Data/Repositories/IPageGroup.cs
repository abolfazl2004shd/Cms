using Cms.Models;
using System.Text.RegularExpressions;

namespace Cms.Data.Repositories
{
    public interface IPageGroup
    {
        PageGroup GetGroupById(int id);
        List<PageGroup> AllGroups();
        bool InsertGroup(PageGroup group);
        bool UpdateGroup(int id);
        bool DeleteGroup(int id);
        bool DeleteGroup(PageGroup group);
        bool Save();
    }
}
