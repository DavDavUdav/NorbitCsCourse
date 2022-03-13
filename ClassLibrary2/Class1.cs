using System;

namespace ClassLibraryBmiWeight
{
    public class ClassBmiWeight
    {
        /// <summary>
        /// рассчитывает индекс массы тела человека.
        /// </summary>
        /// <param name="weight"> вес человека</param>
        /// <param name="height"> рост человека в метрах через запятую</param>
        /// <returns></returns>
        public static double BmiCount(double weight, double height)
        {
            return Math.Round(weight / Math.Pow(height, 2), 1);
        }

        /// <summary>
        /// заполнение массива рандомными значениями и их сортировка.
        /// </summary>
        /// <returns></returns>
        public static int[] ArrayCount()
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(100);
            }
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        
    }
}
