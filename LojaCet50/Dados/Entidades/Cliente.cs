using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LojaCet50.Dados.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }


        public string Morada { get; set; }
    }
}
