using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntity
{
    [Table("Loja")]
    class Loja
    {
        [Key]
        public int LojaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        IEnumerable<Produto> Produtos { get; set; }
    }
}
