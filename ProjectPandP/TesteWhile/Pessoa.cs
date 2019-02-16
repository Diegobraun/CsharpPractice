using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWhile
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Sexo { get; private set; }
        public Profissao Profissao { get; private set; }

        public Pessoa(int id,string nome, int idade, string sexo,Profissao profissao)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
            Profissao = profissao;
        }

        public void SetId (int id)
        {
            Id = id;
        }
        public void SetNome (string nome)
        {
            Nome = nome;
        }

        public void SetIdade (int idade)
        {
            Idade = idade;
        }

        public void SetSexo (string sexo)
        {
            Sexo = sexo;
        }


    }
}
