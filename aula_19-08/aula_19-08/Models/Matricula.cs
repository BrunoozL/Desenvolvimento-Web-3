using System.ComponentModel.DataAnnotations;

namespace aula_19_08.Models
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public DateTime Data {  get; set; }
        public Aluno? Aluno { get; set; }
        [Required]
        [Display(Name = "Aluno")]
        public int AlunoId { get; set; }
        public Curso? Curso { get; set; }
        [Required]
        [Display(Name = "Curso")]
        public int CursoId { get; set;}
    }
}
