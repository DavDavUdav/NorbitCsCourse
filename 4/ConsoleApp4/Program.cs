using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    public delegate bool CheckDelegate(int a, int b); 

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 7, 3, 1, 6, 8, 2, 9, 5, 6, 1 };

            SortArrayClass sa = new SortArrayClass();
            sa.Notify += DisplayMessage;    // Добавляем обработчик события
            sa.SortArray(ref array, sa.SortInt);    

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void DisplayMessage(string message) => Console.WriteLine(message);
    }
 
    class SortArrayClass
    {
        public delegate void DisplayDelegate(string message);   // делегат для события.
        public event DisplayDelegate? Notify;   // Объявляем событие и проверяем на null.

        /// <summary>
        /// метод проверки значений массива
        /// </summary>
        /// <param name="previous"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public bool SortInt(int previous, int next)
        {
            if (previous>next)
            {
                
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод сортировки массива.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="testDelegate"></param>
        public void SortArray(ref int[] array, CheckDelegate checkDelegate)
        {
            if (array is null)
            {
                throw new ArgumentNullException("Пустая коллекция!");
            }

            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (checkDelegate(array[i],array[j]))   // Вызов делегата.
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Notify?.Invoke("Сортировка успешно завершена. \n");     // Вызываем событие.
        }
    }
}
