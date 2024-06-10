using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Endereco : Base
    {

        [Required]
        [Display(Name = "Cep")]
        //Display
        public string Cep { get; set; }

        [Required]
        [Display(Name = "Pais")]
        public string Pais { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Numero")]
        public string Numero { get; set; }
    }
}
