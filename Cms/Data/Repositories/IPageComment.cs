using Cms.Models;

namespace Cms.Data.Repositories
{
    public interface IPageComment
    {
        PageComment GetPageCommentById(int id);
        List<PageComment> PageComments(int pageId);
        List<PageComment> AllComments();
        bool InsertComment(PageComment comment);
        bool DeleteComment(int id);
        bool DeleteComment(PageComment comment);
        bool Save();
    }
}
