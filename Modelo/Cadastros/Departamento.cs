using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Departamento
    {
        [DisplayName("Código Departamento")]
        public long? DepartamentoID { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        
        [DisplayName("Código Instituição")]
        [Required(ErrorMessage = "O campo Instituição é obrigatório")]
        public long? InstituicaoID { get; set; }

        public Instituicao Instituicao { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }

    }
}
