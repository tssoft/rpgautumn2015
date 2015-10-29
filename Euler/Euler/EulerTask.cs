using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// Класс предназначен для решения задач Эйлера
    /// </summary>
    class EulerTask
    {
        /// <summary>
        /// Суммирует простые числа от единицы до указанного числа
        /// </summary>
        /// <param name="number">Число, до которого производится 
        /// суммирование</param>
        /// <returns>сумму простых чисел от единицы до number</returns>
        public static long SumarizePrimesBelow(long number)
        {
            long sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (IsBelow(i))
                    sum += i;
            }

            return sum;
        }

        /// <summary>
        /// Проверяет является ли число простым
        /// </summary>
        /// <param name="number">Проверяемое число</param>
        /// <returns>true, если число просто, false, если число не является 
        /// простым</returns>
        private static bool IsBelow(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

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
