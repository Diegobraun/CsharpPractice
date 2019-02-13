using System;

namespace RefactoringANDTests
{
    public class Calc : object, ICalc
    {
        public Calc()
        {
        }

        public int Somar(int x, int y) => x + y;
        public int Multiplicar(int x, int y) => x * y;
    }
}