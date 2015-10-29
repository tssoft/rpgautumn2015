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
            LagestPrimeFactor lpf = new LagestPrimeFactor();
            Console.Write("Наибольший простой делитель числа 600851475143 есть: ");
            Console.WriteLine(lpf.GetLagestPrimeFactor(600851475143));

            //kuujenga's
            sumsqrdiff obj = new sumsqrdiff();
            obj.difference();
            //0

            int count = 2000000;

            Console.WriteLine(SumarizePrimesBelow.SumPrimesBelow(count));
            Console.WriteLine("Минимальное число, которое делится без остатка на все числа от 1 до 20:");//Решение задачи №5
            //Console.WriteLine(Convert.ToString(MinimumFold.FindingMinimumFold()));
            Console.ReadKey();
        }
    }
}
