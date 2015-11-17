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
            /* Вычисляем наибольший простой делитель числа */
            var lpf = new LargestPrimeFactor();
            long number = 600851475143;
            int lagestPrimeFactor = lpf.ComputeLargestPrimeFactor(number);
            Console.Write(String.Format("Наибольший простой делитель числа {0}: {1}", 
                                        number, 
                                        lagestPrimeFactor));
            Console.WriteLine();

            sumsqrdiff obj = new sumsqrdiff();
            obj.difference();

            IEulerTask[] tasks = { new SumarizePrimesBelowTask(200000) };
            foreach (var task in tasks)
            {
                task.Solve();
                Console.WriteLine(task.t);
                Console.WriteLine(task.Result);
            }



            // 5 задание     
            Console.WriteLine("Минимальное число, которое делится без остатка на все числа от 1 до 20:");
            uint minDigit = MinimumFoldCalculator.FindMinimumFold(1, 20, 2520);
            Console.WriteLine(minDigit);

            // Console.WriteLine("Минимальное число, которое делится без остатка на все числа от 1 до 20:");//Решение задачи №5
            // Console.WriteLine(MinimumFold.FindingMinimumFold());
            Problem_4 p4 = new Problem_4();
            Console.WriteLine("Полиндром произведения 2-х трехзначных чисел:");
            Console.WriteLine(p4.GetPolindrom());
            Console.ReadKey();
        }
    }
}
