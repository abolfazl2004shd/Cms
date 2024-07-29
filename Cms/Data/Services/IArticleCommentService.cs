using Cms.Models;

namespace Cms.Data.Services
{
    public interface IArticleCommentService
    {
        List<ArticleComment> ArticleComments(int ArticleId);
        int NumberOfComments(int ArticleId);
        List<ArticleComment> AllComments(int ArticleId);
        bool InsertComment(ArticleComment comment);
        bool DeleteComment(int id);
        bool DeleteComment(ArticleComment comment);
        bool Save();
    }
}
