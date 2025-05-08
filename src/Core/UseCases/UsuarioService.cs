using Core.Entities;
using Core.Interfaces;

namespace Core.UseCases
{
    public class UsuarioService : IUsuarioService
    {
        private readonly List<Usuario> _usuarios = new(); // temporário

        public Task<IEnumerable<Usuario>> ListarTodosAsync() =>
            Task.FromResult(_usuarios.AsEnumerable());

        public Task<Usuario> BuscarPorIdAsync(int id) =>
            Task.FromResult(_usuarios.FirstOrDefault(u => u.Id == id));

        public Task<Usuario> CriarAsync(Usuario usuario)
        {
            usuario.Id = _usuarios.Count + 1;
            _usuarios.Add(usuario);
            return Task.FromResult(usuario);
        }

        public Task<bool> DeletarAsync(int id)
        {
            var usuario = _usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario == null) return Task.FromResult(false);

            _usuarios.Remove(usuario);
            return Task.FromResult(true);
        }
    }
}