using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfOperador
{
    public class Professor
    {
        public string Matricula { get; set; } = "0";
        public string Nome { get; set; } = "Sem nome";
        public DateTime Data { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"Matricula: {Matricula}, Nome: {Nome}, Data: {Data}";
        }
    }

    public static class Relatorio
    {
        public static void Imprimir (Professor professor)
        {
            Console.WriteLine("Relatório:");
            Console.WriteLine(professor?.ToString() ?? $"O parametro de nome " +
            $"{nameof(professor)} não pode ser nulo!");
        }
        public static void GetType (Professor prof)
        {
            Console.WriteLine(prof.GetType());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Professor gp = null;
            Console.WriteLine(gp?.ToString() ?? $" Objeto {nameof(gp)} não instanciado");
            Relatorio.Imprimir(gp);
            gp = new Professor() { Nome = "Diego", Matricula = "123" };
            Console.WriteLine(gp?.ToString() ?? $" Objeto {nameof(gp)} não instanciado");
            Relatorio.Imprimir(gp);
            Relatorio.GetType(gp);
            Console.ReadLine();
        }
    }
}
