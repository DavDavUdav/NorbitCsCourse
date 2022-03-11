using System;

namespace ClassLibraryWrite
{
    public static class WriteStrings
    {
        /// <summary>
        /// выводит квадрат из звездочек с пустым местом в центре.
        /// </summary>
        /// <param name="n"></param>
        public static char[,] WriteStars(int n)
        {
            int result = (int)((n + 1) / 2);
            char[,] starsSquade = new char[n, n];
            for (int i = 1; i <= n; i++)
            {
                if (i == result)
                {
                    for (int j = 1; j < result; j++)
                    {
                        starsSquade[i - 1, j - 1] = '*';
                    }
                    starsSquade[result , result ] = ' ';
                    for (int j = result+1; j <= n; j++)
                    {
                        starsSquade[i-1 , j-1 ] = '*';
                    }
                }
                else
                {
                    for (int j = 1; j <= n; j++)
                    {
                        starsSquade[i - 1, j - 1] = '*';
                    }
                }
            }
            return starsSquade;
        }

        /// <summary>
        /// выводит последовательность чисел.
        /// </summary>
        /// <param name="n"></param>
        public static int[] WriteNum(int n)
        {
            int[] numbersArr = new int[n];
            for (int i = 1; i <= n; i++)
            {
                numbersArr[i - 1] = i;
            }
            return numbersArr;
        }
    }
}
