using System;
using ClassLibraryBmiWeight;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteBmi();
            ConsoleWriteArray();
        }

        public static void ConsoleWriteBmi()
        {
            Console.WriteLine("Введите массу тела");
            double userWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах(например 1,76)");
            double userHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine( ClassBmiWeight.BmiCount(userWeight,userHeight) );
            Console.ReadKey();
        }

        public static void ConsoleWriteArray()
        {
            int[] arr = ClassBmiWeight.ArrayCount();
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("Минимальный элемент массива - " + arr[0]);
            Console.WriteLine("Максимальный элемент массива - " + arr[arr.Length-1]);
        }
    }
}
