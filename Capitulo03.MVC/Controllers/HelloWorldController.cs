using Microsoft.AspNetCore.Mvc;

namespace Capitulo03.MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string IndexTexto()
        {
            return $"Este é o método '{nameof(Index)}' do {nameof(HelloWorldController)}";
        }

        public IActionResult Welcome(string nome, int idade)
        {
            ViewData["Nome"] = nome;
            ViewData["Idade"] = idade;
            return View();
        }

        public string WelcomeTexto(string nome, int idade)
        {
            return $@"
                Este é o método '{nameof(Welcome)}' do {nameof(HelloWorldController)}.
                Nome: {nome} | Idade: {idade}.
            ".Trim();
        }
    }
}
