using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult ArticleComments()
        {
            return View();
        }
    }
}
