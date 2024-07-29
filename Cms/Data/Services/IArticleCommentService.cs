using Cms.Models;

namespace Cms.Data.Services
{
    public interface IArticleCommentService
    {
        ArticleComment GetArticleCommentById(int id);
        List<ArticleComment> ArticleComments(int ArticleId);
        int NumberOfComments(int ArticleId);
        List<ArticleComment> AllComments();
        bool InsertComment(ArticleComment comment);
        bool DeleteComment(int id);
        bool DeleteComment(ArticleComment comment);
        bool Save();
    }
}
