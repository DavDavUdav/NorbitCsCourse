using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DynamicArray
{
    public class DynamicArray<T>
    {
        object[] array;
        private T[] arrayT;

        int sum;




        /// <summary>
        ///  Создает массив на 8 элементов.
        /// </summary>
        public void CreateArray()
        {
            array = new ArrayList[8];
            
        }
        
        public void CreateArray(int num)
        {
            array = new Array[num];
        }

        public T[] CreateArray(IEnumerable<T> arr)
        {
            int sum = arr.Count();

            arrayT = arr.ToArray();
            return arrayT;
        }

        public int[] Add(int[] arr)
        {
            sum = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                sum++;
                Console.WriteLine(arr[i] + " " + sum);


            }
            return arr;
            
        }

        public string[] Add(string[] arr)
        {
            sum = 0;
            int count = arr.Count();

            for (int i = 0; i < count; i++)
            {
                
                if (arr[i]!=null && arr[i]!=" ")
                {
                    sum++;
                }
            }

            if (sum<arr.Count())
            {
                arr[sum] = "Hello";
                return arr;
            }
            else
            {
                var newArray = new string[count * 2];
                for (int i=0;i<count;i++)
                {
                    newArray[i] = arr[i];
                }
                newArray[count] = "Hello";
                return newArray;
            }   
        }

        /// <summary>
        /// Добавляет коллекцию в конец массива.
        /// </summary>
        /// <param name="col"> Коллекция. </param>
        /// <returns></returns>
        public T[] AddRange(IEnumerable<T> col, T[] array )
        {
            int sum1 = array.Count();   // Количество элементов массива.
            int sum2 = col.Count();     // Количество элементов коллекции.
            int count = 0;

            arrayT = new T[sum1+sum2];  // Создаем T[] нужного размера.
            array.CopyTo(arrayT,0);     // Копируем массив в T[].
            var testarr = col.ToArray();    // Копируем коллекцию в массив.

            for (int i=sum1;i<sum1+sum2;i++)    // присваиваем значения оставшихся элементов.
            {
                arrayT[i] = testarr[count++];
            }
            
            // Тестирование на работоспособность.
            for(int i=0;i<arrayT.Count();i++)
            {
                Console.WriteLine(arrayT[i]);
            }
            return arrayT;
        }
    }
}
