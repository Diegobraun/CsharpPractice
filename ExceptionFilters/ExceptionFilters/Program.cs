using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 999999999;
            int Y = 999999999;
            int R1 = 0;
            int R2 = 0;
            int R3 = 10;
            int R4 = 0;

            try
            {
                //R1 = R3 / R4;
                //Console.WriteLine($"{R3} dividido por {R4} é = a {R1}");
                R2 = checked(X * Y);
                Console.WriteLine($"{X} multiplicado por {Y} é = a {R2}");
            }
            //catch (DivideByZeroException E)
            //{
            //    Console.WriteLine($"{E.Message}");
            //}
            //catch(OverflowException E)
            //{
            //    Console.WriteLine($"{E.Message}");
            //}
            //catch(ArithmeticException E)
            //{
            //    Console.WriteLine($"{E.Message}");
            //}
            catch(Exception E) when (E.Message.ToUpper().Contains("ESTOURO"))
            {
                Console.WriteLine($"{E.Message}");
            }
           

            Console.ReadLine();
        }
    }
}
