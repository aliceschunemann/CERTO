using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class CursoDisciplina
    {
        [DisplayName("Código do Curso")]
        public long? CursoID { get; set; }
        
        public Curso Curso { get; set; }
        
        [DisplayName("Código da Disciplina")]
        [Required(ErrorMessage = "O campo Disciplina é obrigatório")]
        public long? DisciplinaID { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}