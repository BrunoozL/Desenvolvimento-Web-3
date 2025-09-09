using System.ComponentModel.DataAnnotations;

namespace aula_02_09.Models
{
    public class User
    {
        [Required(ErrorMessage = "Preencha o campo.")]
        [Display(Name = "Nome Completo")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Preencha o campo.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha o campo.")]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}
