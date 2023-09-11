using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Discente
{
    public class Academico
    {
        [DisplayName("Código do Acadêmico")]
        public long? AcademicoID { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [RegularExpression("([0-9]{10})")]
        [Required(ErrorMessage = "O campo Registro Acadêmico (RA) é obrigatório")]
        [DisplayName("RA")]
        public string RegistroAcademico { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [DisplayName("Nome do Acadêmico")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório")]
        [DisplayName("Data de Nascimento do Acadêmico")]
        public DateTime? Nascimento { get; set; }

        public string FotoMimeType { get; set; }
        public byte[] Foto { get; set; }

        [NotMapped]
        public IFormFile FormFile { get; set; }
    }
}