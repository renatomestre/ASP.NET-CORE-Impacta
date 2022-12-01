using Mestreflix.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mestreflix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["baseUri"] = $"//{Request.Host}";

            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Movies");
            else
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}