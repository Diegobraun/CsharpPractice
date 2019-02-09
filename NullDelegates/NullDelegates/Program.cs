using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullDelegates
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe valor do pedido: ");
            var valor = Convert.ToDouble(Console.ReadLine());
            var pedido = new Pedido();
            pedido.Pagar += v => Console.WriteLine($"Pago valor de {v} no boleto");
            pedido.Fechar(valor);
            Console.ReadLine();
        }

        //private static void Pedido_Pagar(double valor)
        //{
        //    Console.WriteLine($"Pago valor de {valor} no boleto");
        //}
    }
}
