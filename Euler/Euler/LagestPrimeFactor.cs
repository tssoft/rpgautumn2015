using System;
using System.Collections.Generic;

namespace Euler
{
    /// <summary>
    /// Класс, вычисляющий наибольший простой делитель числа
    /// </summary>
    public class LagestPrimeFactor
    {
        // Конструктор по умолчанию
        public LagestPrimeFactor() 
        { }

        // Получить наибольший общий простой делитель числа 
        public int GetLagestPrimeFactor(long number)
        {
            List<int> primeNumbers = GetRangePrimeFactor((int)Math.Sqrt(number));
            for (int i = primeNumbers.Count - 1; i > 1; i--)
            {
                if (number % primeNumbers[i] == 0)
                {
                    return primeNumbers[i];
                }
            }
            return -1;
        }

        // Получаем ряд простых чисел
        private List<int> GetRangePrimeFactor(int num)
        {
            // получаем список булевых переменных 
            List<bool> listOfBool = GetListOfBool(num);
            // вычерикваем составные числа от 2 до заданного
            listOfBool = CrossOutNumber(listOfBool);
            // получаем список простых чисел
            return GetListOfInt(listOfBool);   
        }

        // Получаем список булевых значений
        private List<bool> GetListOfBool(int num)
        {
            List<bool> listOfBool = new List<bool>();
            for (int i = 0; i < num; i++)
            {
                listOfBool.Add(true);
            }
            return listOfBool;
        }

        // Вычеркиваем составные числа
        private List<bool> CrossOutNumber(List<bool> listOfBool)
        {
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
           return listOfBool;
        }

        // Получаем список простых чисел
        private List<int> GetListOfInt(List<bool> listOfBool)
        {
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
