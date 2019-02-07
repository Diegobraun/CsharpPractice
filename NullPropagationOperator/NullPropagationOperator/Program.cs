using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPropagationOperator
{
    public class Aluno
    {
        public int Matricula { get; set; } = 0;
        public string Nome { get; set; } = "Sem nome";
        public Curso Curso { get; set; }
    }

    public class Curso
    {
        public int Codigo { get; set; } = 0;
        public string NomeCurso { get; set; } = "Sem nome";
        public Area Area { get; set; }
    }

    public class Area
    {
        public string NomeDaArea { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var gp = new Aluno()
            {
                Matricula = 123,
                Nome = null
            ,
                Curso = new Curso() { NomeCurso = "Sistemas de Informação", Area = new Area() { NomeDaArea = "exatas" } }
            };
            Console.WriteLine($"Nome: {gp.Nome}, Matricula: {gp.Matricula}");
            Console.WriteLine($"Curso: {gp?.Curso?.NomeCurso ?? "Sem curso"}");
            Console.WriteLine($"Área: { gp?.Curso?.Area?.NomeDaArea ?? "Sem área"}");
            Console.WriteLine($"Sim {gp?.Nome ?? "Não"}");
            var a = "";
            a = $"{ gp?.Nome ?? "ish"}" ;
            Console.Write(a);
            Console.ReadLine();
        }
    }
}
