using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {


        static void Main(string[] args)
        {
            //kuujenga's
            sumsqrdiff obj = new sumsqrdiff();
            obj.difference();
            Console.ReadKey();
            //0

            int count = 2000000;

            Console.WriteLine(SumarizePrimesBelow.SumPrimesBelow(count));
            Console.ReadLine();
        }
    }
}
