using Cms.Data.Context;
using Cms.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public ActionResult Index()
        {
            var articles = _articleService.AllArticles();
            return View(viewName: nameof(Index), model: articles);
        }

        public ActionResult Search(string query)
        {
            var articles = _articleService.Filter(query);
            return View(viewName: nameof(Index), model: articles);
        }
    }
}
