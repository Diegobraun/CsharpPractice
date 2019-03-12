using System;

namespace InferenceTypes
{
    public class Connection{
        public string ConnectionString;
        public void Conectar(){
            Console.WriteLine("Conectando");
        }
        public void Fechar(){
            Console.WriteLine("Fechando conexão");
        }
    }

    public class Fabrica{
        public static Connection CriarConnection(){
            return new Connection();
        }
    }
    class Program{
        static void Main(string[] args)
        {
            var con = Fabrica.CriarConnection();
            con.Conectar();   

            dynamic conn = Fabrica.CriarConnection();
            conn.Conectar();         
        }
    }
}
