using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor a depositar: ");
            var v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor a sacar: ");
            var v2 = Convert.ToDouble(Console.ReadLine());
            var c = new Conta();
            c.Depositar(v1);
            c.Sacar(v2);
            Console.WriteLine($"Sua conta tem saldo de {c.GetSaldo()}");
            Console.ReadKey();

        }
    }
    
}
