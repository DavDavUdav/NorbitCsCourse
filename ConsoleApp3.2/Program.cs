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
            Console.WriteLine("Hello World!");

            var test = new List<string> { "11","23","21","229"};

            var test1 = new List<string> { "111", "233", "21", "229","233", "21", };

            var dynamicArray = new DynamicArray<string>();

            

            
            Console.WriteLine(dynamicArray.Capacity);
            for (int i=0;i<dynamicArray.Capacity;i++)
            {
                Console.WriteLine(i + ") " + dynamicArray.GetElement(i));
            }

            dynamicArray.AddRange(test1);
            Console.WriteLine("Вывод нового массива :");
            for (int i = 0; i < dynamicArray.Capacity; i++)
            {
                Console.WriteLine(i + ") " + dynamicArray.GetElement(i));
            }

            dynamicArray.Insert("a2",8);
            Console.WriteLine("Insert. Вывод нового массива :");
            for (int i = 0; i < dynamicArray.Capacity; i++)
            {
                Console.WriteLine(i+") "+dynamicArray.GetElement(i));
            }
            Console.ReadKey();
        }

        public static void CreateTest()
        {

        }

        public static void AddTest()
        {

        }

        public static void AddRangeTest()
        {
            var test = new List<string> { "11", "23", "21", "229" };

            var dynamicArray = new DynamicArray<string>();


        }

        public static void RemoveTest()
        {
            var dynamicArray = new DynamicArray<string>();

            dynamicArray.Remove("21");
            Console.WriteLine("Вывод нового массива :");

            for (int i = 0; i < dynamicArray.Capacity; i++)
            {
                Console.WriteLine(dynamicArray.GetElement(i));
            }
            Console.WriteLine("емкость массива: " + dynamicArray.Capacity);
        }

        

    }
}
