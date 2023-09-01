using System.ComponentModel.DataAnnotations;

namespace AAAAAAAAAAAAAAAa.Models.Infra
{
    public class AcessarViewModel
    {
        [Required(ErrorMessage = "Preencha esse campo!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha esse campo!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Lembrar de mim?")]
        public bool LembrarDeMim { get; set; }
    }
}
