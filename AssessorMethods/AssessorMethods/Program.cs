using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessorMethods
{
    public class Conta
    {
        private string Cliente;
        private double Valor;
        public Conta (string nomeCliente)
        {
            Cliente = nomeCliente;
        }

        public Conta()
        {
         
        }

        public string getCliente()
        {
            return Cliente;
        }

        public void setCliente (string nomeCliente )
        {
            Cliente = nomeCliente;
        }

        public void Sacar(double valor)
        {
            Valor = Valor - valor;
        }

        public void Depositar (double valor)
        {
            Valor += valor;
        }

        public double getValor()
        {
            return Valor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.setCliente("Diego");
            c.Depositar(1000);
            c.Sacar(500);
            Console.WriteLine(c.getCliente());
            Console.WriteLine(c.getValor());
            Console.ReadLine();
        }
    }
}
