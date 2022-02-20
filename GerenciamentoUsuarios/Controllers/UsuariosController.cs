using GerenciamentoUsuarios.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GerenciamentoUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario
            {
                Id = 1,
                Name = "Joe",
                Cpf = "12345678910",
                Senha = "1234567890",
                Email ="Joe@joe.com"
            },

            new Usuario
            {
                Id = 2,
                Name = "Mathew",
                Cpf = "12345678910",
                Senha = "1234567890",
                Email ="mathew@joe.com"
            },

            new Usuario
            {
                Id = 3,
                Name = "Mark",
                Cpf = "12345678910",
                Senha = "1234567890",
                Email ="mark@joe.com"
            }
        };


       
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return Ok(usuarios);
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




        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
