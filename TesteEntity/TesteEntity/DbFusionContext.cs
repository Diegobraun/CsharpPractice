using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntity
{
    class DbFusionContext : DbContext
    {
        public DbFusionContext() : base("BancoClientes")
        {

        }

        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
