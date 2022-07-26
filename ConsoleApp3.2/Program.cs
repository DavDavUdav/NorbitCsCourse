using System;
using System.Collections.Generic;
using System.Linq;
using DynamicArray;

namespace ConsoleApp3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultList = new List<string> { "11", "23", "21", "229" };
            var addList = new List<string> { "111", "233", "21", "229", "233", "21", };

            var dynamicArray = new DynamicArray<string>();

            Console.WriteLine($"Создан массив на 8 элементов, сейчас заполнено элементов: {dynamicArray.Length}");
            DisplayArray(dynamicArray);     // вывод массива на экран

            Console.WriteLine("Добавляем элемент в массив");
            dynamicArray.Add("aaa");
            DisplayArray(dynamicArray);

            Console.WriteLine("Добавляем группу элементов в массив");
            dynamicArray.AddRange(addList);
            DisplayArray(dynamicArray);

            
            Console.WriteLine("Удаляем элемент массива(если таких несколько то удаляются все)");
            dynamicArray.Remove("21");
            DisplayArray(dynamicArray);

            Console.WriteLine("Добавляем элемент в любую позицию массива");
            dynamicArray.Insert("a2", 8);
            DisplayArray(dynamicArray);
            
            Console.ReadKey();
        }

       

        

       

        

        

        public static void DisplayArray(DynamicArray<string> dynamicArray)
        {
            Console.WriteLine($"Емкость массива: {dynamicArray.Capacity}");
            Console.WriteLine($"Кол-во заполненных элементов в массиве: {dynamicArray.Length}");

            for (int i = 0; i < dynamicArray.Capacity; i++)
            {
                Console.WriteLine(i + ") " + dynamicArray[i]);
            }
        }

        
    }
}
