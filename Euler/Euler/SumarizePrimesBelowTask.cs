using System;

namespace Euler
{
    internal class SumarizePrimesBelowTask : AbstractEulerTask
    {
        private long number;
        private long sum;

        public SumarizePrimesBelowTask(long number)
        {
            this.number = number;
        }

        protected override string Title
        {
            get { return string.Format("Сумма первых {0} простых чисел", number); }
        }

        public string Result { get { return sum.ToString(); } }

        public override void Solve()
        {
            sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (IsBelow(i))
                {
                    sum += i;
                }
            }
        }

        /// <summary>
        /// Проверяет является ли число простым
        /// </summary>
        /// <param name="parNumber">Проверяемое число</param>
        /// <returns>true, если число просто, false, если число не является 
        /// простым</returns>
        private static bool IsBelow(int parNumber)
        {
            if (parNumber == 1) return false;
            if (parNumber == 2) return true;

            bool result = true;
            int i = 2;
            int boundary = (int)Math.Floor(Math.Sqrt(parNumber));
            while (result && ++i <= boundary)
            {
                result = parNumber % i == 0;
            }
            return result;
        }
    }
}
