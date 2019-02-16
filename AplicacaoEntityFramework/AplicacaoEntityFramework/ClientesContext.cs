using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AplicacaoEntityFramework
{
    class ClientesContext:DbContext
    {
        public ClientesContext() : base("BancoClientes")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
