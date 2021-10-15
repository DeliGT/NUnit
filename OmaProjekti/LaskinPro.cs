using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleA_Test
{
    public class LaskinPro
    {
        public int Square(int num)
        {
            return num * num;
        }
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Multiply(int num1, int num2)
        { 
            if (num1 == 0 && num2 == 0)
                throw new NullReferenceException("Laskutoimitus on turha.");
            else
                return num1 * num2;
        }
        public int Subtract(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }

            return num2 - num1;

        }
        public float Division(float num1, float num2)
        {
            return num1 / num2;
        }
        public bool Guess_equation(float app, float guess)
        {
            if (app == guess)
                return true;
            else
                return false;
        }

    }
}
