using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NullDelegates
{
    //public class Boleto
    //{
    //    public void Pagar(double valor)
    //    {
    //        WriteLine($"Pago valor de {valor} no boleto");
    //    }
    //}
    public delegate void PagarEvent (double valor);

    public class Pedido
    {
        public event PagarEvent Pagar;
        //Boleto boleto = new Boleto();
        public void Fechar(double valor)
        {
            //delegação
            //if (Pagar != null)
            //    Pagar(valor);
            //else
            //    WriteLine("Não existem formas de pagamento!");
            Pagar?.Invoke(valor);
        }


    }
}
