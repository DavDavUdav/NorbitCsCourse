using System;
using System.Collections.Generic;
using System.Linq;
using DynamicArray;

namespace ConsoleApp3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var test = new List<string> { "11","23","21","229"};

            var dynamicArray = new DynamicArray<string>();

            var array = new string[8];
            array[0] = "1";
            array[1] = "11";
            array[2] = "12";
            array[3] = "13";
            array[4] = "13";
            array[5] = "13";
            array[6] = "13";
            array[7] = "14";

            dynamicArray.AddRange(test, array);
            /*
            string[] a = dynamicArray.CreateArray(test);

            for (int i=0;i<a.Count();i++)
            {
                Console.WriteLine(a[i]);
            }
            
            var array = new string[8];
            array[0] = "1";
            array[1] = "11";
            array[2] = "12";
            array[3] = "13";
            array[4] = "13";
            array[5] = "13";
            array[6] = "13";
            array[7] = "13";
            

            var myArray = dynamicArray.Add(array);

            for(int i=0;i<myArray.Count();i++)
            {
                Console.WriteLine(myArray[i]+" = "+i);
            }
            */
        }

        

    }
}
