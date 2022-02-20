using Microsoft.EntityFrameworkCore;

namespace GerenciamentoUsuarios.Models
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Usuario>(entity => {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(e => e.Cpf).IsUnique();
            });
            
            base.OnModelCreating(builder);
        }

        public DbSet<Usuario> usuarios { get; set; }
    }
}
