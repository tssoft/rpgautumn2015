using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class sumsqrdiff
    {

        public void difference()
        {
            int diff = 0, sumsqr = 0, sqrsum = 0; //difference, sum of squares, square of sum
            for (int i = 1; i < 100; i++)
            {
                sumsqr += (i * i);
            };
            for (int j = 1; j < 100; j++)
            {
                sqrsum += j;
            };
            sqrsum = sqrsum * sqrsum;
            diff = sqrsum - sumsqr;
            Console.WriteLine(" Difference of sumsqr and sqrsum of first 100 natural\n numbers " + diff);
        }
    }
}
