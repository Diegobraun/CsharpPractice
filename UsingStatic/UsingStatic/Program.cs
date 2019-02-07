using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UsingStatic
{
    
    class Program
    {
        static void Main(string[] args)
        {
           /// var calc = new Calc();
            var r = Calc.Somar(3, 5);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
