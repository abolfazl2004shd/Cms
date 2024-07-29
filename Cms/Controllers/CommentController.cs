using Cms.Data.Services;
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
    

        //public ActionResult AddCommnent() { }
    }
}
