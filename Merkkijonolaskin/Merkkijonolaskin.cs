using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleA_Test
{
    public class MerkkijonoLaskin
    {

        public int Laske(string text)
        {

            if (EmptyString(text))
            {
                return 0;
            }

            string newText = text.Replace("\n", ",").Replace("\\n", ",");
            string[] nums = newText.Split(",");
            int total = 0;

            foreach (string number in nums)
            {
                int num = int.Parse(number);

                if (LessThanZero(num))
                    throw new ArgumentException("Negatiivisia lukuja ei sallita");

                if (HigherThanOneThousans(num))
                    total += num;
            }
            return total;
        }

        private static bool HigherThanOneThousans(int num)
        {
            return num < 1000;
        }

        private static bool LessThanZero(int num)
        {
            return num < 0;
        }

        private static bool EmptyString(string text)
        {
            return text == null;
        }
    }
}