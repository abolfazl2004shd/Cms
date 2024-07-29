using Cms.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var article = _articleService.GetArticleById(id);
            return View(viewName: nameof(Details), model: article);
        }
        //public ActionResult RelatedArticles(int id)
        //{
        //    return PartialView();
        //}

       
    }
}
