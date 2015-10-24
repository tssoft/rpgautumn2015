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
            //kuujenga's
            sumsqrdiff obj = new sumsqrdiff();
            obj.difference();
            Console.ReadKey();
            //0

            int count = 2000000;

            Console.WriteLine(SumarizePrimesBelow.SumPrimesBelow(count));
            Console.ReadLine();
            Console.WriteLine("Минимальное число, которое делится без остатка на все числа от 1 до 20:");//Решение задачи №5
            Console.WriteLine(Convert.ToString(MinimumFold.FindingMinimumFold()));
            Console.ReadKey();

        }
    }
}
