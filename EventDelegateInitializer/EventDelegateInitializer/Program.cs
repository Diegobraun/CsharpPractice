using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do pedido: ");
            var valor = Convert.ToDouble(Console.ReadLine());
            var pedido = new Pedido()
            {
                Cliente = "Diego",
                Pagar = (s,e) => Console.WriteLine("Pago no cartão")
            };
            pedido.Fechar(valor);
            Console.ReadLine();
        }

        private static void Pedido_Pagar(object sender, EventArgs e)
        {
            Console.WriteLine($"Pago no boleto");
        }
    }
}
