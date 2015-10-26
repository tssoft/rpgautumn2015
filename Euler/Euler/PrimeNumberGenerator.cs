using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// генератор простых чисел
    /// </summary>
    public class PrimeNumberGenerator
    {
        // переменная, хранящая текущее простое число
        private Int64 _val;
        public Int64 Value 
        {
            get
            {
                return _val;
            }
            set 
            { 
                _val = value < 2 ? 2 : value; 
            } 
        }
        // основной конструктор
        public PrimeNumberGenerator(Int64 startNumber)
        {
            Reset(startNumber);
        }
        // получить следующее простое число в ряду
        public Int64 GetNext()
        {
            Boolean isPrime;
            for (Int64 i = Value; i < Int64.MaxValue; i++)
            {
                isPrime = true;
                for (Int64 j = 2; j < i / j + 1; j++)
                {
                    if (i % j == 0)
                    {
                        // число не является простым
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Value = i + 1;
                    return i;
                }
            }
            return 0;
        }
        // получить предыдущее простое число в ряду
        public Int64 GetPrev()
        {
            Boolean isPrime;
            for (Int64 i = Value; i >= 2; i--)
            {
                isPrime = true;
                for (Int64 j = 2; j < i / j + 1; j++)
                {
                    if (i % j == 0)
                    {
                        // число не является простым
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Value = i - 1;
                    return i;
                }
            }
            return 0;
        }
        // установка счетчика в новое исходное состояние
        public void Reset(Int64 startNumber)
        {
            Value = startNumber;
        }

    }
}
