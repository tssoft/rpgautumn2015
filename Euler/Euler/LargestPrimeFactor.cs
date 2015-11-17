using System;
using System.Collections;
using System.Collections.Generic;

namespace Euler
{
    /// <summary>
    /// Класс, вычисляющий наибольший простой делитель числа
    /// </summary>
    public class LargestPrimeFactor
    {
        /// <summary>
        /// Метод находит наибольший простой делитель
        /// числа
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Наибольший простой делитель числа</returns>
        public int ComputeLargestPrimeFactor(long number)
        {
            // Строим ряд простых чисел
            IList<int> primeNumbers = AmassPrimeFactorRow((int)Math.Sqrt(number));
            // Возвращаем наибольший общий простой делитель числа
            return FindLargestPrimeFactor(primeNumbers, number);
        }

        /// <summary>
        /// Метод находит наибольший простой делитель
        /// числа и в ряду простых чисел
        /// </summary>
        /// <param name="primeNumbers">Ряд простых чисел</param>
        /// <param name="number">Исследуемое число</param>
        /// <returns>Наибольший простой делитель числа</returns>
        private int FindLargestPrimeFactor(IList<int> primeNumbers, long number)
        {
            for (int i = primeNumbers.Count - 1; i > 1; i--)
            {
                if (number % primeNumbers[i] == 0)
                {
                    return primeNumbers[i];
                }
            }
            return -1;
        }

        /// <summary>
        /// Метод строит ряд простых чисел
        /// </summary>
        /// <param name="sz">Длина ряда</param>
        /// <returns>Ряд простых чисел</returns>
        private IList<int> AmassPrimeFactorRow(int sz)
        {
            // Строим числоваой ряд
            bool[] numberSequence = new bool[sz];
            // Вычерикваем составные числа с 2-ух
            numberSequence = CrossOutNumber(numberSequence);
            // Возвращаем список простых чисел
            return CreatePrimaryNumbersRow(numberSequence);   
        }

        /// <summary>
        /// Из числового ряда вычеркиваются все составные
        /// числа
        /// </summary>
        /// <param name="numberSequence">Числовой ряд</param>
        /// <returns>Числовой ряд с вычеркнутыми составными числами</returns>
        private bool[] CrossOutNumber(bool[] numberSequence)
        {
           for (int i = 2; i * i < numberSequence.Length; i++)
            {
                if (numberSequence[i])
                {
                    for (int j = i * i; j < numberSequence.Length; j += i)
                    {
                        numberSequence[j] = true;
                    }
                }
            }
           return numberSequence;
        }

        /// <summary>
        /// В методе создается ряд простых чисел
        /// </summary>
        /// <param name="numberSequence">
        /// Числовой ряд с вычеркнутыми составными числами
        /// </param>
        /// <returns>Ряд простых чисел</returns>
        private IList<int> CreatePrimaryNumbersRow(bool[] numberSequence)
        {
            IList<int> primaryNumbersRow = new List<int>();
            for (int i = 2; i < numberSequence.Length; i++)
            {
                if (!numberSequence[i])
                {
                    primaryNumbersRow.Add(i);
                }
            }
            return primaryNumbersRow;
        }
    }
}
