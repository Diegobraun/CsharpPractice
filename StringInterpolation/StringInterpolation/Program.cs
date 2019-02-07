using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StringInterpolation
{
    public class Pessoa
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa
            {
                Matricula = 123,
                Nome = "Diego",
                Sobrenome = "Braun"
            };
            
            //Console.WriteLine("Bem-vindo " + p.Nome + " " + p.Sobrenome + "(" + p.Matricula + " ),este é o c# 6");
            //Console.WriteLine("Bem vindo {0} {1} ({2})", p.Nome, p.Sobrenome, p.Matricula);
            Console.WriteLine($"Bem vindo {p.Nome} {p.Sobrenome} ({p.Matricula})");
            Console.WriteLine($"Agora são {DateTime.Now}");
            Console.ReadLine();
        }
    }
}
