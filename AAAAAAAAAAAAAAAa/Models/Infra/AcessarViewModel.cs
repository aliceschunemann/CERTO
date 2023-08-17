﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AAAAAAAAAAAAAAAa.Models.Infra
{
    public class AcessarViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Display(Name = "Lembrar de mim?")]
        public bool LembrarDeMim { get; set; }
    }
}
