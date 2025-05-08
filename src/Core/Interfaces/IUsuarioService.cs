using Core.Entities;

namespace Core.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ListarTodosAsync();
        Task<Usuario> BuscarPorIdAsync(int id);
        Task<Usuario> CriarAsync(Usuario usuario);
        Task<bool> DeletarAsync(int id);
    }
}