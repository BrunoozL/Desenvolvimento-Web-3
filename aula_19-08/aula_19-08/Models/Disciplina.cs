using System.ComponentModel.DataAnnotations;

namespace aula_19_08.Models
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
        public Curso? Curso { get; set; }
        [Required]
        [Display(Name = "Curso")]
        public int CursoId { get; set; }
    }
}
