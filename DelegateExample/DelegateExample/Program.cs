using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        public delegate void ExemploDelegate();

        public static void Ex()
        {
            Console.WriteLine("Opa");
        }

        static void Main(string[] args)
        {
            ExemploDelegate x = new ExemploDelegate(Ex);
            x.Invoke();
            Console.ReadKey();
        }
    }
}
