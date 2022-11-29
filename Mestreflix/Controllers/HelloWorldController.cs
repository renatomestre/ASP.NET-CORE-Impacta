using Microsoft.AspNetCore.Mvc;

namespace Mestreflix.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string IndexString()
        {
            return $"Controller {nameof(HelloWorldController)} - Método {nameof(HelloWorldController.Index)}";
        }

        public IActionResult Welcome()
        {
            return View();
        }

        public string WelcomeString(string name = "<sem nome>", int numTimes = 1)
        {
            return $@"
                Controller {nameof(HelloWorldController)} - Método {nameof(HelloWorldController.Welcome)}
                Welcome, {name}! Vezes: {numTimes}.
            ";
        }
    }
}
