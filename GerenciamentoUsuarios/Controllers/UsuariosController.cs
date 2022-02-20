using GerenciamentoUsuarios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GerenciamentoUsuarios.Criptografia;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciamentoUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly _DbContext _context;

        public UsuariosController(_DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (!_context.usuarios.Any())
                return Ok("Não há usuários cadastrados");

            return Ok(await _context.usuarios.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Usuario usuario)
        {
            var verificaCpf = _context.usuarios.FirstOrDefault(option => option.Cpf == usuario.Cpf);
            var verificarEmail = _context.usuarios.FirstOrDefault(option => option.Email==usuario.Email);
            

            if (verificaCpf != null)
            {
                return Conflict("Este CPF já está cadastrado");
            }
            else if (verificarEmail != null)
            {
                return Conflict("Este E-mail já está cadastrado");
            }

            usuario.Senha = Encrypt.HashSenha(usuario.Senha);

            _context.usuarios.Add(usuario);

            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var usuario = await _context.usuarios.FindAsync(id);
            if (usuario == null)
                return BadRequest("Usuario nao encontrado");
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Usuario>>> Edit(int id,Usuario request)
        {
            var dbUsuario = await _context.usuarios.FindAsync(id);
            if (dbUsuario is null)
                return NotFound("Usuario nao encontrado.");
            
            dbUsuario.Name = request.Name;
            dbUsuario.Email = request.Email;  
            dbUsuario.Cpf=request.Cpf;
            dbUsuario.Senha = Encrypt.HashSenha(request.Senha);
            dbUsuario.DataNasc = request.DataNasc;

            var verificaCpf = _context.usuarios.FirstOrDefault(option => option.Cpf == request.Cpf);
            var verificarEmail = _context.usuarios.FirstOrDefault(option => option.Email == request.Email);


            if (verificaCpf != null)
            {
                return Conflict("Este CPF já está cadastrado");
            }
            else if (verificarEmail != null)
            {
                return Conflict("Este E-mail já está cadastrado");
            }


            await _context.SaveChangesAsync();

            return Ok(dbUsuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Usuario>>> Delete(int id)
        {
            var dbUsuario = await _context.usuarios.FindAsync(id);
            if (dbUsuario == null)
                return BadRequest("Usuario nao encontrado");
            _context.usuarios.Remove(dbUsuario);
            await _context.SaveChangesAsync();  
            return Ok("Exclusão realizada com sucesso");
        }




    }
}
