using Microsoft.AspNetCore.Mvc;

namespace Capitulo03.Exercicio.Livraria.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
