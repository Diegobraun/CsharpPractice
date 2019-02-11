using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetReadOnly
{
    public class Conta
    {
        //antes do csharp 6
        public double Saldo { get;  private set; } = 1000;

        public string Cliente { get; set; }

        public void Sacar(double valor)
        {
            Saldo = Saldo - valor;
        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        //public double getSaldo()
        //{
        //    return Saldo;
        //}

    }
}
