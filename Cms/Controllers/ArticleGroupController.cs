using Cms.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Controllers
{
    public class ArticleGroupController : Controller
    {
        private readonly IArticleGroupService _articleGroupService;

        public ArticleGroupController(IArticleGroupService articleGroupService)
        {
            _articleGroupService = articleGroupService;
        }
        public IActionResult GroupsListing()
        {
            var groups = _articleGroupService.AllGroups();
            return PartialView(viewName: nameof(GroupsListing), model: groups);
        }
    }
}
