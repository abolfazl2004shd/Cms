using Cms.Data.Services;
using Cms.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    public class CommentController : Controller
    {
        private readonly IArticleCommentService _articleCommentService;

        public CommentController(IArticleCommentService articleCommentService)
        {
            _articleCommentService = articleCommentService;
        }


      
        public ActionResult AddComment(int id, string content)
        {
            ArticleComment comment = new()
            {
                ArticleId = id,
                Content = content,
                RegistrationDate = DateTime.Now,
            };
            _articleCommentService.InsertComment(comment);
            _articleCommentService.Save();
            var articles = _articleCommentService.ArticleComments(id);
            //     return PartialView(nameof(DisplayComments), model: articles);
            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }
    }
}
