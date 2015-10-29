namespace Euler
{
    /// <summary>
    /// Решение 5 задачи Эйлера. Класс для нахождения минимального кратного.
    /// </summary>
    /// Авторы: Баринова Е.А., Милантьев А.А.
    public static class MinimumFoldCalculator
    {
        /// <summary>
        /// Метод для нахождения наименьшего кратного.
        /// </summary>
        /// <param name="parLeftBound"></param>
        /// <param name="parRightBound"></param>
        /// <param name="refMinDigit"></param>
        /// <returns name="refMinDigit"></returns>
        public static uint FindMinimumFold(int parLeftBound, int parRightBound, uint refMinDigit)
        {
            bool found = false;
            while (!found)
            {
                refMinDigit++;
                for (int i = parLeftBound; i <= parRightBound; i++)
                {
                    if (refMinDigit % i != 0)
                    {
                        break;
                    }
                    found = i == parRightBound;
                }
            }
            return refMinDigit;
        }
    }
}
