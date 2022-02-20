using GerenciamentoUsuarios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciamentoUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>
        {
        };

        private readonly _DbContext _context;

        public UsuariosController(_DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return Ok(await _context.usuarios.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Usuario>>> AddUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
            return Ok(usuarios);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<Usuario>>> Get(int id)
        {
            var usuario = usuarios.Find(x => x.Id == id);
            if (usuario == null)
                return BadRequest("Usuario nao encontrado");
            return Ok(usuario);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<List<Usuario>>> Edit(Usuario request)
        {
            var usuario = usuarios.Find(x => x.Id == request.Id);
            if (usuario == null)
                return BadRequest("Usuario nao encontrado");
            usuario.Name = request.Name;
            usuario.Email = request.Email;  
            usuario.Cpf=request.Cpf;
            usuario.Senha = request.Senha;

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Usuario>>> Delete(int id)
        {
            var usuario = usuarios.Find(x => x.Id == id);
            if (usuario == null)
                return BadRequest("Usuario nao encontrado");
            usuarios.Remove(usuario);
            return Ok(usuarios);
        }




    }
}
