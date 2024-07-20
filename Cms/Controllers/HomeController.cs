using Cms.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
