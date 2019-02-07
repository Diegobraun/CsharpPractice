using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionBodies
{
    public delegate void PagarEvent(double valor);

    public class Pedido
    {
        public event PagarEvent Pagar;

        public void Fechar(double valor)
        {
            Pagar(valor);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var pedido = new Pedido();
            pedido.Pagar += v => Console.WriteLine($"Pago valor de {v}");
            pedido.Fechar(2000);
            Console.ReadKey();
        }

        private static void Pedido_Pagar(double valor)
        {
            Console.WriteLine($"Pago valor de {valor}");
        }
    }
}
