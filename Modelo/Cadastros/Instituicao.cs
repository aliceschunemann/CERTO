using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
    public class Instituicao
    {
        [DisplayName("Código Instituição")]
        public long? InstituicaoID { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "O campo Endereço é obrigatório")]
        public string Endereco { get; set; }
        
        public virtual ICollection<Departamento> Departamentos{ get; set; }

    }
}
