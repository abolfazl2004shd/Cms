using Cms.Models;
using System.Text.RegularExpressions;

namespace Cms.Data.Services
{
    public interface IArticleGroupService
    {
        ArticleGroup GetGroupById(int id);
        List<ArticleGroup> AllGroups();
        bool InsertGroup(ArticleGroup group);
        bool UpdateGroup(int id);
        bool DeleteGroup(int id);
        bool DeleteGroup(ArticleGroup group);
        bool Save();
    }
}
