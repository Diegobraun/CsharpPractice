using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli = new Cliente
            {
                Nome = "Diego",
                Credito = 900,
                Idade = 18
            };
            ClientesContext db = new ClientesContext();
            db.Clientes.Add(cli);
            db.SaveChanges();
            Console.WriteLine("Exito");
            Console.ReadKey();
        }
    }
}
