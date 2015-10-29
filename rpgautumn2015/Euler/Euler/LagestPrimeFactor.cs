using System;
using System.Collections.Generic;

namespace Euler
{
    /// <summary>
    /// Класс, вычисляющий наибольший простойделитель числа
    /// </summary>
    public class LagestPrimeFactor
    {
        public LagestPrimeFactor() 
        { }

        public int GetLagestPrimeFactor(long number)
        {
            List<int> primeNumbers = CalculateEratosthenSieve((int)Math.Sqrt(number));
            for (int i = primeNumbers.Count - 1; i > 1; i--)
            {
                if (number % primeNumbers[i] == 0)
                {
                    return primeNumbers[i];
                }
            }
            return -1;
        }

        private List<int> CalculateEratosthenSieve(int num)
        {
            List<bool> listOfBool = new List<bool>();
            for (int i = 0; i < num; i++)
            {
                listOfBool.Add(true);
            }
            for (int i = 2; i * i < listOfBool.Count; i++)
            {
                if (listOfBool[i])
                {
                    for (int j = i * i; j < listOfBool.Count; j += i)
                    {
                        listOfBool[j] = false;
                    }
                }
            }
            List<int> listOfInt = new List<int>();
            for (int i = 2; i < listOfBool.Count; i++)
            {
                if (listOfBool[i])
                {
                    listOfInt.Add(i);
                }
            }
            return listOfInt;
        }
    }
}
