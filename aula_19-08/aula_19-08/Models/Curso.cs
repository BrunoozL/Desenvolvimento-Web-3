using System.ComponentModel.DataAnnotations;

namespace aula_19_08.Models
{
    public class Curso
    {
        public int CursoID { get; set; }
        [Required]
        [Display(Name = "Curso")]
        public string? Nome { get; set; }

        public List<Disciplina>? Disciplinas;
    }
}
