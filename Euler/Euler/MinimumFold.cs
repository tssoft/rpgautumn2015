using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    public static class MinimumFold
    {
        static int leftBound = 1, rightBound = 20;
        static uint minDigit = 2520;
        /*public MinimumFold()
        {
            leftBound = 11;
            rightBound = 20;
            minDigit = 2520;
        }*/
        public static uint FindingMinimumFold()
        {
            bool flag = false;
            uint MD = minDigit;
            while (flag != true)
            {
                MD++;
                for (int i = leftBound; i <= rightBound; i++)
                {
                    if (MD % i != 0)
                        break;
                    if (i == 20)
                        flag = true;
                }

            }
            return MD;
        }
    }
}
