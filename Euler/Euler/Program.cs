using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    static class problem_4
    {
        static public void solution()
        {
            int number1, number2, result;
            number1 = 999;
            number2 = 999;
            while (number1 > 0)
            {
                while (number2 > 0)
                {
                    result = number1 * number2;
                    if (problem_4.polindrom(result))
                    {

                    }
                    number2--;
                }
                number1--;
            }
        }
        static public bool polindrom(int number)
        {
            string pol = number.ToString();
            if (problem_4.even(pol.Length))
            {
                
            }
        }

        static public bool even(int number)
        {
            if ((number % 2) == 0) return (true);
            else return (false);
        }
    }
}
