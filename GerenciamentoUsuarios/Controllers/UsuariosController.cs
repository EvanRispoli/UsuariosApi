﻿using GerenciamentoUsuarios.Models;
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
            _context.usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return Ok(await _context.usuarios.ToListAsync());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<Usuario>>> Get(int id)
        {
            var usuario = await _context.usuarios.FindAsync(id);
            if (usuario == null)
                return BadRequest("Usuario nao encontrado");
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Usuario>>> Edit(Usuario request)
        {
            var dbUsuario = await _context.usuarios.FindAsync(request.Id);
            if (dbUsuario == null)
                return BadRequest("Usuario nao encontrado");
            
            dbUsuario.Name = request.Name;
            dbUsuario.Email = request.Email;  
            dbUsuario.Cpf=request.Cpf;
            dbUsuario.Senha = request.Senha;

            await _context.SaveChangesAsync();

            return Ok(await _context.usuarios.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Usuario>>> Delete(int id)
        {
            var dbUsuario = await _context.usuarios.FindAsync(id);
            if (dbUsuario == null)
                return BadRequest("Usuario nao encontrado");
            _context.usuarios.Remove(dbUsuario);
            await _context.SaveChangesAsync();  
            return Ok(await _context.usuarios.ToListAsync());
        }




    }
}
