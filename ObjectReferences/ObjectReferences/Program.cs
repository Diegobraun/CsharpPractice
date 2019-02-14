using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectReferences
{

    public class Cliente 
    {
        public int Codigo;
        public string Nome;
        public string Telefone;
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Codigo: "+Codigo);
            sb.AppendLine("Nome: "+Nome);
            sb.AppendLine("Telefone: "+Telefone);
            return sb.ToString();
        }
    }

    class Program
    {
        public static void MostrarValueTypes()
        {
            int x = 10;
            string s = "Diego";
            bool b = false;
            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);
        }

        static void Main(string[] args)
        {

            Cliente c1 = new Cliente();
            c1.Codigo = 123;
            c1.Nome = "Diego";
            c1.Telefone = "99999999";
            Cliente c2 = c1;
            c2.Nome = "Rodolfo";
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            if (c1.Equals(c2))
                Console.WriteLine("São iguais");
            //Console.WriteLine(c.Codigo);
            //Console.WriteLine(c.Nome);
            //Console.WriteLine(c.Telefone);

            Console.ReadKey();
        }
    }
}
