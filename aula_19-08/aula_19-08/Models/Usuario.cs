using System.ComponentModel.DataAnnotations;

namespace aula_19_08.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required]
        [Display(Name = "Nome Completo")]
        public string? Nome { get; set; }
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Senha { get; set; }
    }
}
