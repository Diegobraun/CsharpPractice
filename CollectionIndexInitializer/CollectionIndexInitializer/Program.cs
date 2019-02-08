using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionIndexInitializer
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        //public Aluno (string nome)
        //{
        //    this.Nome = nome;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>();
            lista.Add("opa");
            lista.Add("aeaeea");
            lista.Add("dfafd");
            lista.Add("dfafd");
            lista.Add("sdads");
            lista.Add("htath");
            lista.Add("tratt");
            lista.Add("weaw");
            lista.Add("weaw");

            var Alunos = new Dictionary<int, Aluno>()
            {
                 [1] = new Aluno() { Nome = "Diego", Sobrenome = "Braun"} ,
                 [2] = new Aluno() { Nome = "Fred", Sobrenome = "Turner"} ,
                 [12] = new Aluno(){ Nome = "opa",Sobrenome = "opa"},
                 

            };
            var lambda = from l in lista.Where(l => l.Contains("a")) select l;

            foreach (var A in lambda)
            {
                Console.WriteLine(A.ToString());
            }
            

            Console.WriteLine($"Aluno: {Alunos[2].Nome}");
            Console.ReadKey();

            //Alunos.Add(1, new Aluno() { Nome = "Diego", Sobrenome = "Braun" });
            //Alunos.Add(2, new Aluno() { Nome = "Diego", Sobrenome = "Braun" });

            //var a1 = new Aluno()
            //{
            //  Nome = "Diego",
            //  Sobrenome = "Braun"
            //};

            //var Alunos = new List<Aluno>()
            //{
            //    new Aluno() { Nome = "Diego", Sobrenome = "Braun"},
            //    new Aluno() { Nome = "Alberto", Sobrenome = "Fraga"}
            //};
            //Alunos.Add(new Aluno() { Nome = "Diego", Sobrenome = "Braun" });

        }
    }
}
