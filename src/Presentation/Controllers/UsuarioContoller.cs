using Microsoft.AspNetCore.Mvc;
using Core.Entities;
using Core.Interfaces;
using Presentation.DTOs;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await _usuarioService.ListarTodosAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _usuarioService.BuscarPorIdAsync(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioDTO dto)
        {
            var novo = new Usuario(dto.Nome, dto.Email, dto.Telefone, dto.Senha);
            _usuarios.Add(novo);
            return CreatedAtAction(nameof(GetById), new { id = novo.Codigo }, novo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var removido = await _usuarioService.DeletarAsync(id);
            if (!removido) return NotFound();
            return NoContent();
        }
    }
}
