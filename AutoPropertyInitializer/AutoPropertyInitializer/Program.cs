using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertyInitializer
{
    class Program
    {

        static void Main(string[] args)
        {
            var gp = new Aluno1(123,"Diego");
            Console.WriteLine($" { gp.Nome} {gp.Matricula}");
            //Console.ReadLine();

            ///

            var gp2 = new Aluno() { Matricula = 1211, Nome = "opaaa" };
            Console.WriteLine($"{gp2.Nome} {gp2.Matricula}");
            Console.ReadLine();
        }
    }
}
