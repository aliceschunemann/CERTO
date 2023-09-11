using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Docente
{
    public class Professor
    {
        [DisplayName("Código do Professor")]
        public long? ProfessorID { get; set; }
        
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [DisplayName("Nome do Professor")]
        public string Nome { get; set; }

        public virtual ICollection<CursoProfessor> CursosProfessores { get; set; }
}
}
