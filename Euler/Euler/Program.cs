using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem_4.Solution();
            //Console.ReadKey();            
            LagestPrimeFactor lpf = new LagestPrimeFactor();
            Console.Write("Наибольший простой делитель числа 600851475143 есть: ");
            Console.WriteLine(lpf.GetLagestPrimeFactor(600851475143));
            sumsqrdiff obj = new sumsqrdiff();
            obj.difference();

            int count = 200000;
            Console.Write("\nСумма первых " + count + " простых чисел: ");
            Console.WriteLine(EulerTask.SumarizePrimesBelow(count));

            Console.WriteLine("Минимальное число, которое делится без остатка на все числа от 1 до 20:");//Решение задачи №5
            Console.WriteLine(MinimumFold.FindingMinimumFold());
            Problem_4 p4 = new Problem_4();
            Console.WriteLine("Полиндром произведения 2-х трехзначных чисел:");
            Console.WriteLine(p4.Solution());
            Console.ReadKey();
        }
    }
}
