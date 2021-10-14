using System;

namespace ConsoleA_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Harjoitus");
            Console.WriteLine("Anna luku 1 - 100 välillä:");
            var buzz = new FizzBuzz();
            Console.WriteLine(buzz.DoFizzBuzz(Convert.ToInt32(Console.ReadLine())));
        }
    }
    public class FizzBuzz
    {
        public string DoFizzBuzz(int luku)
        {
 
            bool fizz = luku % 3 == 0;
            bool buzz = luku % 5 == 0;
            if (fizz && buzz)
                return "FizzBuzz";
            else if (fizz)
                return "Fizz";
            else if (buzz)
                return "Buzz";
            else
                return luku.ToString();
            
        }
    }
}
