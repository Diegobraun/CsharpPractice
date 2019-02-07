using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertyInitializer
{
    public class Aluno1
    {
        public int Matricula
        {
            get { return Matricula1; }
            set { Matricula1 = value; }
        }

        public string Nome { get; set; }
        public int Matricula1 { get; set; }

        public Aluno1 (int matricula, string nome)
        {
            Matricula1 = matricula;
            Nome = nome;
        }

        public Aluno1()
        {
            Matricula1 = 0;
            Nome = "";
        }
    }
}
