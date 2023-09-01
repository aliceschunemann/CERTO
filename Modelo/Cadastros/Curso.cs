using Modelo.Docente;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Curso
    {
        [DisplayName("Código Curso")]
        public long? CursoID { get; set; }
        
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Departamento é obrigatório")]
        [DisplayName("Código Departamento")]
        public long? DepartamentoID { get; set; }

        public Departamento Departamento { get; set; }

        public virtual ICollection<CursoDisciplina> CursosDisciplinas { get; set; }
        public virtual ICollection<CursoProfessor> CursosProfessores { get; set; }

    }
}