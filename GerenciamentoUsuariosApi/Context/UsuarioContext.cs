using GerenciamentoUsuariosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoUsuariosApi.Context
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            : base(options)=> Database.EnsureCreated();

        public Usuario Usuario { get; set; }


    }
}
