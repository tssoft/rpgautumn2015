﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    internal class Program
    {


        private static void Main(string[] args)
        {
            Problem_4.Solution();
            Console.ReadKey();

        }
    }

    internal static class Problem_4
    {
        public static void Solution()
        {
            int number1;
            int number2;
            int result;
            number1 = 999;
            number2 = 999;
            while (number1 > 0)
            {
                while (number2 > 0)
                {
                    result = number1*number2;
                    Console.WriteLine(result);
                    if (Problem_4.IsPolindrom(result))
                    {
                        Console.WriteLine(result);
                    }
                    number2--;
                }
                number1--;
            }
        }

        public static bool IsPolindrom(int number)
        {
            string pol = number.ToString();
            string firstHalf;
            string secondHalf;

            if (Problem_4.even(pol.Length))
            {
                firstHalf = pol.Substring(0, (pol.Length/2 - 1));
                secondHalf = pol.Substring((pol.Length/2));
                if (firstHalf.Equals(secondHalf.Reverse()))
                {
                    return true;
                }

            }
            else
            {
                int part;
                int temp = Math.DivRem(pol.Length + 1, 2, out part);
                firstHalf = pol.Substring(0, temp - 1);
                secondHalf = pol.Substring(temp + 1);
                if (firstHalf.Equals(secondHalf.Reverse()))
                {
                    return true;
                }
            }
            return false;
        }


        public static bool even(int number)
        {
            if ((number%2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}