using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoUsuarios.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(120)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, MaxLength(10)]
        public string Senha { get; set; }
        [Required, MinLength(11),MaxLength(11)]
        public string Cpf { get; set; }
    }
}
