using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Disciplina
    {
        [DisplayName("Código Disciplina")]
        public long? DisciplinaID { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        public virtual ICollection<CursoDisciplina> CursosDisciplinas { get; set; }
    }
}