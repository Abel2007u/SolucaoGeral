using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Funcionario : Base
    {
        [Required]
        [Display(Name = "Nome do Funcionario")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Cargo")]
        public string Funcao { get; set; }

        [Required]
        [Display(Name = "Salario")]
        public decimal Salario { get; set; }

        public DateTime DataDeContratacao { get; set; }

        public DateTime DataDeDemicao { get; set; }


    }
}
