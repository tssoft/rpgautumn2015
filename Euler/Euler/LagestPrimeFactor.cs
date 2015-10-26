using System;
using System.Collections.Generic;

namespace Euler
{
    /// <summary>
    /// Класс, вычисляющий наибольший простой
    /// делитель числа
    /// </summary>
    public class LagestPrimeFactor
    {
        // конструктор по умолчанию
        public LagestPrimeFactor() { }
        // получить наибольший простой делитель числа
        public Int32 GetLagestPrimeFactor(Int64 number)
        {
            List<Int32> primeNumbers = EratosthenSieve((Int32)Math.Sqrt(number));

            for (Int32 i = primeNumbers.Count - 1; i > 1; i--)
            {
                if (number % primeNumbers[i] == 0)
                {
                    return primeNumbers[i];
                }
            }
            return -1;
        }
        // решето Эратосфена, вычисляет ряд простых чисел
        private List<Int32> EratosthenSieve(Int32 num)
        {
            List<Boolean> listOfBool = new List<Boolean>();

            for (Int32 i = 0; i < num; i++)
            {
                listOfBool.Add(true);
            }

            for (Int32 i = 2; i * i < listOfBool.Count; i++)
            {
                if (listOfBool[i] == true)
                {
                    for (Int32 j = i * i; j < listOfBool.Count; j += i)
                    {
                        listOfBool[j] = false;
                    }
                }
            }

            List<Int32> listOfInt = new List<Int32>();

            for (Int32 i = 2; i < listOfBool.Count; i++)
            {
                if (listOfBool[i] == true)
                {
                    listOfInt.Add(i);
                }
            }

            return listOfInt;
        }
    }
}
