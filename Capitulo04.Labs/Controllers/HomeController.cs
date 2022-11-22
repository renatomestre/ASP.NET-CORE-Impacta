using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capitulo04.Labs.Controllers
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

        public ActionResult ListarSuppliers()
        {
            var db = new NorthwindEntities();
            return View(db.Suppliers.ToList());
        }

        public ActionResult ListarProdutos()
        {
            var db = new dbFirstModelContainer();
            return View(db.Produtos.ToList());
        }

    }
}