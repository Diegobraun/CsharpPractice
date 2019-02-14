using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEStructEEnum
{
    public class PosicaoClass
    {
        public int X;
        public int Y;
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }

    public struct PosicaoStruct
    {
        public int X;
        public int Y;
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }

    public enum Role
    {
        Arquiteto, Developer, Tester
    }

    public enum Color
    {
        Red = 0, Green = 1, Blue = 2
    }

    public enum FormasPagto
    {
        Boleto, Cartao, Cheque
    }

    class Program
    {
        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;
            PosicaoStruct pos2 = new PosicaoStruct();
            pos2.X = 30;
            pos2.Y = 40;
            PosicaoStruct pos3 = pos2; // values types
            pos3.Y = 50;

            FormasPagto formaPgto = FormasPagto.Boleto;
            Role role = Role.Developer;
            Color color = Color.Blue;

            Console.WriteLine(role);
            Console.WriteLine(color);
            Console.WriteLine(formaPgto);
            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);
            Console.ReadKey();
        }
    }
}
