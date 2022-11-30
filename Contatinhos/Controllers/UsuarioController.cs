using Contatinhos.Models;
using Contatinhos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Contatinhos.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();
            return View(usuarios);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _usuarioRepositorio.Adicionar(usuario);
                    TempData["MensagemSucesso"] = "Usuario Cadastrado com Sucesso";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"ops, algo deu errado erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Editar(int id)
        {
            var usuario = _usuarioRepositorio.BuscarPorId(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Editar(UsuarioModel model)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepositorio.Atualizar(model);
                TempData["SuccessMessage"] = "Editado com sucesso";
                return RedirectToAction(nameof(Editar), new { id = model.Id });
            }
            TempData["ErrorMessage"] = "Verifique os campos e tente novamente";
            return View(model);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            var usuario = _usuarioRepositorio.BuscarPorId(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult ApagarConfirmacaoPost(int id)
        {
            _usuarioRepositorio.Apagar(id);
            TempData["SuccessMessage"] = "Apagado com sucesso";
            return RedirectToAction(nameof(Index));
        }
    }
}
