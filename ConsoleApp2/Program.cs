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
            WriteAverageWords();
        }

        public static void ConsoleWriteBmi()
        {
            Console.WriteLine("Введите массу тела");
            double userWeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах(например 1,76)");
            double userHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine( ClassBmiWeight.BmiCount(userWeight,userHeight) );
            Console.WriteLine("Работа модуля закончена, нажмите любую кнопку для продолжения");
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
            Console.WriteLine("Работа модуля закончена, нажмите любую кнопку для продолжения");
        }

        public static void WriteAverageWords()
        {     
            Console.WriteLine("Среднее значение длинны слов - "+ClassBmiWeight.AverageWord(Console.ReadLine()));
        }

        public static void TestStructLearning()
        {
            Persone persone;
            persone.name = "Степан";
            persone.age = 18;
            persone.Print();
        }

        struct Persone
        {
            public string name;
            public int age;

            public void Print() =>Console.WriteLine($"Имя:{name}, возраст: {age}");
            
        }
    }
}
