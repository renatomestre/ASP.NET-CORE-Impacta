using Contatinhos.Models;

namespace Contatinhos.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorId(int id);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel ListarPorId(int Id);
        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);
    }
}
