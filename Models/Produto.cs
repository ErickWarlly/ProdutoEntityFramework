using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Demostracao.Models
{
    [Table("produto")]
    public class Produto
    {
        [Column("id")]
        [Display(Name = "Codigo")]
        public int id { get; set; }

        [Column("descricao")]
        [Display(Name = "Descricao")]
        public string descricao { get; set; }

        [Column("valor")]
        [Display(Name = "Valor")]
        public float valor { get; set; }

    }
}