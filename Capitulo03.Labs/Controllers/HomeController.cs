using Microsoft.AspNetCore.Mvc;

namespace Capitulo03.Labs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarErro()
        {
            ViewBag.MensagemErro = "Erro interno do servidor";
            return View("_Erro");
        }
    }
}