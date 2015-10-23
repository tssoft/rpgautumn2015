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
            int count = 2000000;
            long sum = 0;

            for(int i = 1; i < count; i++)
            {
                if (isBelow(i))
                    sum += i;                
            }

            Console.WriteLine(sum);
            Console.ReadLine();
            
        }

        private static bool isBelow(int number)
        {
            int boundary = (int) Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;  
        }

    }
}
