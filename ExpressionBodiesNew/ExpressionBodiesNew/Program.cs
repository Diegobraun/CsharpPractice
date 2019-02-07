using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExpressionBodiesNew
{
    public static class Calculadora
    {
        public static string Nome = "Calculadora 1";
        public static int Somar(int X, int Y) => X + Y;
        public static int Multiplicar(int X, int Y) => X * Y;
        //{
        //    return X + Y;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var r = Calculadora.Somar(10, 20);
            WriteLine($"Soma: {r}, Multiplicação: {Calculadora.Multiplicar(2,3)} usando a calculadora {Calculadora.Nome = "oba"}");
            ReadKey();
        }
    }
}
