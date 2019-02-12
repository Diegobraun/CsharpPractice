using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDebugging
{
    public class Aluno
    {
        public int Matricula;
        public string Nome;
        public double Mensalidade;
    }

    public static class Repositorio
    {
        public static List<Aluno> GetAlunos()
        {
            var lista = new List<Aluno>();
            lista.Add(new Aluno() { Matricula = 1, Nome = "Guinther", Mensalidade = 1000 });
            lista.Add(new Aluno() { Matricula = 2, Nome = "Diego", Mensalidade = 2000 });
            lista.Add(new Aluno() { Matricula = 3, Nome = "Cleber", Mensalidade = 500 });
            return lista;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a matrícula: ");
            var Matricula = Console.ReadLine();
            var alunos = Repositorio.GetAlunos();
            var qr = alunos.Where(a => a.Matricula == Convert.ToInt32(Matricula));
            var first = qr.FirstOrDefault();
            Console.WriteLine(first.Nome + first.Matricula);
            Console.ReadKey();
        }
    }
}
