using System;
using ClassLibraryBmiWeight;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteBmi();
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

    }
}
