using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Conta()
            {
                Cliente = "Diego"
            };
            c.Saldo = 1000;
            Console.WriteLine($"Prezado {c.Cliente} seu saldo é {c.Saldo}");
            Console.ReadKey();
           
        }
    }
}
