using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem_4
    {
        public int GetPolindrom()
        {
            List<int> numbers = new List<int>();
            bool flag = false;
            for (int i = 1000; i >= 100; i--)
            {
                for (int j = 1000; j >= 100; j--)
                {
                    string numberStr = (j * i).ToString();
                    int lengthNumberStr = numberStr.Length;

                    if (numberStr.Length % 2 == 1)
                    {
                        string left = numberStr.Substring(0, lengthNumberStr / 2);
                        string right = numberStr.Replace(left, "").Substring(1);
                        IsPolindrom(left, right, numbers, i * j);
                    }
                    else
                    {
                        string left = numberStr.Substring(0, lengthNumberStr / 2);
                        string right = numberStr.Replace(left, "");
                        IsPolindrom(left, right, numbers, i * j);
                    }
                }
            }
            return numbers.Max();
        }

        private static void IsPolindrom(string left, string right, List<int> numbers, int mult)
        {
            if (left.Equals(String.Concat<char>(right.Reverse())))
            {
                numbers.Add(mult);
            }
        }
    }
}
