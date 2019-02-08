using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    public class Aluno
    {
        public string Nome { get; set; } = "Diego";
        public int Matricula { get; set; } = 0;
        public override string ToString()
        {
            return $"Matricula: {Matricula} - Nome: {Nome}";
        }

    }
    public class AlunoEspecial : Aluno
    {
        public string Situacao { get; set; } = "Especial";
        public override string ToString()
        {
            return $"Matricula: {Matricula} - Nome: {Nome} - Situação: {Situacao}";
        }
    }
    class Program
    {
        static void Mostrar(string obj)
        {
            Console.WriteLine($"Mostrar string: {obj}");
        }

        static void Mostrar (int obj)
        {
            Console.WriteLine($"Mostrar(int): {obj}");
        }
        static void Mostrar(bool obj)
        {
            Console.WriteLine($"Mostrar(bool): {obj}");
        }

        static void Mostrar (object obj)
        {
            Console.WriteLine($"Mostrar(obj) {obj}");
        }

        static void Mostrar (Aluno obj)
        {
            Console.WriteLine($"Mostrar(aluno) {obj}");
        }

        static void Mostrar(AlunoEspecial obj)
        {
            Console.WriteLine($"Mostrar(AlunoEspecial) {obj}");
        }
        static void Main(string[] args)
        {
            Mostrar("Olá Mundo");
            Mostrar(10);
            Mostrar(true);
            Mostrar(new Aluno());
            Mostrar(new AlunoEspecial() { Matricula = 123, Nome = "Diegol" });
            Console.ReadKey();
        }
    }
}
