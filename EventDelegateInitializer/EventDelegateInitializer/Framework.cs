using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegateInitializer
{

    //public class Boleto
    //{
    //    public void Pagar(double valor)
    //    {
    //        Console.WriteLine($"Pago valor de {valor} no boleto");
    //    }
    //}
    //public delegate void PagarEvent(double valor);

    public class Pedido
    {
        public string Cliente { get; set; }
        public EventHandler<EventArgs> Pagar { get; set; }

        public void Fechar(double valor)
        {
            // Boleto boleto = new Boleto();
            //delegação com delegate
            Pagar(this, new EventArgs());
        }


    }
}
