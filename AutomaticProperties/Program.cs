using System;

namespace AutomaticProperties
{
    public class Funcionario{
        public int Codigo { get; set;}
        public string Nome { get; set;}
        public double Salario { get; set;}

        public Funcionario(){
            Codigo = 0;
            Nome = "";
            Salario = 0;
        }

        public Funcionario(int codigo, string nome, double salario){
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario(
            123,
            "Diego",
            1000);
            
            Console.ReadLine();
        }
    }
}
