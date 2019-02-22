using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntity
{
    [Table("Produto")]
    class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        public string Descricao { get; set; }

        [ForeignKey("Loja")]
        public int LojaId { get; set; }
        public Loja Loja { get; set; }
    }
}
