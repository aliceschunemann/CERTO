using Modelo.Cadastros;
using System.ComponentModel;

namespace Modelo.Docente
{
    public class CursoProfessor
    {
        [DisplayName("Código Curso")]
        public long? CursoID { get; set; }

        [DisplayName("Curso")]
        public Curso Curso { get; set; }

        [DisplayName("Código Professor")]
        public long? ProfessorID { get; set; }

        [DisplayName("Professor")]
        public Professor Professor { get; set; }
    }

}
