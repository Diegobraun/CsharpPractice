using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndOverload
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;
        //standard
        public Cliente()
        {
            Codigo = 0;
            Nome = "Sem nome";
            Contato = new Contato();
        }

        public Cliente(int codigo)
        {
            Codigo = codigo;
            Nome = "Sem nome";
            Contato = new Contato();
        }

        public Cliente (int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Codigo} = {Nome}";
        }
    }

    public class ClienteVip : Cliente
    {
        public int Tempo;
        public ClienteVip(int codigo, string nome,int tempo)
            :base(codigo,nome)
        {  
            Tempo = tempo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            
            cli1.Codigo = 123;
            cli1.Nome = "Diego";
            cli1.Contato.Tipo = "Telefone";
            cli1.Contato.Descricao = "999999999";

            Cliente cli2 = new Cliente(123);
            cli2.Nome = "Diegol2";

            Cliente cli3 = new Cliente(456,"Foi3");

            ClienteVip cli4 = new ClienteVip(123,"blabla",14);

            Console.WriteLine(cli1);
            Console.WriteLine(cli2);
            Console.WriteLine(cli3);
            Console.WriteLine(cli4);
            Console.ReadLine();
        }
    }
}
