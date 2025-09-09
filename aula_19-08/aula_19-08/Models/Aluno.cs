using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aula_19_08.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        [Display(Name = "RA")]
        [Required]
        public string? Ra { get; set; }
        public Usuario? Usuario  { get; set; }
        [Display(Name = "Usuários")]
        [Required]
        public int UsuarioId { get; set; }
    }
}
