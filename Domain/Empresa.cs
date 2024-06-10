using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
        public class Empresa : Base
        {
            [Required]
            [Display(Name = "Nome da Empresa")]
            public string Nome { get; set; }

            [Required]
            [Display(Name = "CNPJ")]
            public int CNPJ { get; set; }

            [Required]
            [Display(Name = "Presidente")]
            public string CEO { get; set; }

            public DateTime DataDeAbertura { get; set; }

            public DateTime DataDeExtincao { get; set; }

            [Required]
            [Display(Name = "Nome do Funcionario")]
            public Funcionario Funcionario { get; set; }
        }
}
