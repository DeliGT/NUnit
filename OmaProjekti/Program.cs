using System;

namespace ConsoleA_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            LaskinPro sq = new LaskinPro();
            Console.WriteLine(sq.Square(12));
            Console.WriteLine(sq.Add(8, 63));
            Console.WriteLine(sq.Multiply(5, 8));
            Console.WriteLine(sq.Subtract(10, 42));
            Console.WriteLine(sq.Subtract(0, 0));
            Console.WriteLine(sq.Division(3, 4));
            Console.ReadLine();
        }
    }
}
