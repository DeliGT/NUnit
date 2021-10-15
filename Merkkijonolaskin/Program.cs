using System;

namespace ConsoleA_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijonolaskin");
            Console.WriteLine("Anna luvut jotka haluat laskettavan yhteen: ");
            string input = Console.ReadLine();

            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            Console.WriteLine("Laskujen summa: " + laskin.Laske(input));
        }
    }
}